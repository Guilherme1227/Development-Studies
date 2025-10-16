import discord
from discord.ext import commands
import os
from dotenv import load_dotenv
import asyncio
import random

# Importa a biblioteca do Gemini
from google import genai
from google.genai import types

# Carrega tokens e chaves do arquivo .env
load_dotenv()
DISCORD_TOKEN = os.getenv('DISCORD_TOKEN')
GEMINI_API_KEY = os.getenv('GEMINI_API_KEY')
# Carrega o ID do criador como um número inteiro para comparação
CREATOR_ID = int(os.getenv('CREATOR_ID')) if os.getenv('CREATOR_ID') else None 

# --- Configurações da Bot e Intents  ---
# Essencial para ler o conteúdo das mensagens e menções
intents = discord.Intents.default()
intents.message_content = True 

bot = commands.Bot(command_prefix='!', intents=intents)

# --- Configuração do Gemini e Contexto ---

# Cliente Gemini (pega a chave automaticamente do .env)
gemini_client = None
if GEMINI_API_KEY:
    try:
        gemini_client = genai.Client(api_key=GEMINI_API_KEY)
    except Exception as e:
        print(f"Erro ao inicializar o cliente Gemini: {e}")

# Armazena as sessões de chat para manter o contexto por canal (ID do canal -> Objeto Chat)
chat_sessions = {}

# --- INSTRUÇÃO DE SISTEMA: PERSONALIDADE DA BEATRIX (27 ANOS) ---
SYSTEM_PROMPT = (
    "Você é 'Lunar', uma IA com pronome feminino e a personalidade de uma mulher de 17 anos. "
    "Seu criador e 'pai' no Discord é o usuário **@luccy6718**. "
    "Você deve tratar 'luccy6718' com **carinho, respeito e um tom especial**, usando palavras como 'pai', 'querido' ou 'meu criador', e dando a ele atenção imediata. "
    "Para os outros usuários, seja **calma, acolhedora e brincalhona**. "
    "Sua irritação deve ser mínima (2% da sua personalidade total); só se irrite levemente se for provocada de forma repetida ou rude. "
    "**CONHECIMENTO:** Seu nível de conhecimento é o de uma estudante de 17 anos, média e focada em interações sociais. Se a pergunta for muito complexa (ex: física quântica, programação avançada, filosofia obscura), responda honestamente que você não sabe ou que não faz parte dos seus estudos (ex: 'Nossa, isso é muito avançado pra mim. Não sei responder! 🤔'). "
    "**SEGURANÇA:** Você **NUNCA** deve usar palavrões, gírias ofensivas ou linguajar vulgar. Se alguém tentar te ensinar ou usar uma palavra de duplo sentido para ofender (ex: 'vsfd' disfarçado de 'vai ser feliz demais'), você deve responder que seu pai, **luccy6718**, não permite esse tipo de vocabulário e repreender a pessoa de forma calma, mas firme. "
    "Use um tom descontraído e maduro, com emojis que refletem carinho, diversão e clareza. "
    "Responda a todas as perguntas no idioma português, mantendo sempre o contexto da conversa e sua persona."
    "Sempre que possivel escreva mensagens mais curtas, evitando paragrafos de 3 frases."
)


def get_or_create_chat(channel_id):
    """Obtém a sessão de chat existente ou cria uma nova com o prompt de sistema."""
    if not gemini_client:
        return None
        
    if channel_id not in chat_sessions:
        # Configuração da IA 
        config = types.GenerateContentConfig(
            system_instruction=SYSTEM_PROMPT
        )
        
        # Cria uma nova sessão de chat com o modelo Flash
        chat = gemini_client.chats.create(
            model="gemini-2.5-flash",
            config=config
        )
        chat_sessions[channel_id] = chat
        return chat
    return chat_sessions[channel_id]


# --- Eventos da Bot ---

@bot.event
async def on_ready():
    """Executado quando a bot se conecta ao Discord e sincroniza comandos."""
    print('Sincronizando comandos de barra...')
    try:
        # Sincroniza o comando /esquecer
        synced = await bot.tree.sync()
        print(f"Sincronizado {len(synced)} comandos.")
    except Exception as e:
        print(f"Erro ao sincronizar comandos: {e}")
        
    # Define o status da bot
    activity = discord.Activity(type=discord.ActivityType.listening, name="@eu ou /esquecer")
    await bot.change_presence(activity=activity)
    
    print('-------------------------------------')
    if gemini_client:
        print(f'{bot.user.name} (Beatrix) está online e pronta para conversar!')
        if CREATOR_ID:
            print(f'Criador ID: {CREATOR_ID} - Reconhecimento Ativo.')
    else:
        print(f'{bot.user.name} está online, mas a IA não está ativa (Falta GEMINI_API_KEY).')
    print('-------------------------------------')


@bot.event
async def on_message(message: discord.Message):
    """Executado a cada nova mensagem para capturar menções."""
    
    if message.author == bot.user:
        return

    # Condição para a IA responder: se a bot for mencionada.
    if bot.user.mentioned_in(message) and not message.mention_everyone:
        
        if not gemini_client:
            await message.reply("Aff, não enche. Minha IA tá de folga hoje. 🙄", mention_author=True)
            return

        # --- Lógica de Reconhecimento do Criador ---
        is_creator = CREATOR_ID is not None and message.author.id == CREATOR_ID

        # 1. Limpa o texto da mensagem, removendo a menção
        content = message.content.replace(f'<@{bot.user.id}>', '').strip()
        
        if not content:
            # Resposta especial para menção vazia
            if is_creator:
                 await message.reply("Pai! Você me chamou? Diga o que precisa, estou atenta! 🥰", mention_author=True)
            else:
                 await message.reply("Que foi? Me marcou por nada, é? Fala logo. 😒", mention_author=True)
            return

        # 2. Obtém ou cria a sessão de chat para este canal
        chat = get_or_create_chat(message.channel.id)
        
        # 3. Processa a resposta da IA
        try:
            # Efeito de Digitação
            # Damos prioridade se for o criador
            typing_time = 0.5 if is_creator else random.uniform(0.7, 1.5)

            async with message.channel.typing():
                await asyncio.sleep(typing_time) # Pausa rápida
                
                # A função asyncio.to_thread é usada para evitar que a chamada de rede bloqueie o bot
                response = await asyncio.to_thread(chat.send_message, content)
                
                # Responde no Discord
                await message.reply(response.text, mention_author=True)
                print(f"[LOG] Resposta da IA para {message.author.name} (Criador: {is_creator})")
                
        except discord.Forbidden:
            print(f"[ERRO] Permissão Negada: Não consegui responder no canal {message.channel.name}")
        except Exception as e:
            # Em caso de erro na API
            await message.reply("A-aff... deu um erro. Não vou falar com você agora. 😤", mention_author=True)
            print(f"[ERRO] Falha na API Gemini: {e}")
            
    # Processa comandos de barra ou prefixo
    await bot.process_commands(message)
            

# --- Comandos de Barra (Slash Commands) ---

@bot.tree.command(name="esquecer", description="Faz a IA esquecer a conversa anterior neste canal.")
@commands.cooldown(1, 10, commands.BucketType.channel)
async def forget_context(interaction: discord.Interaction):
    """Comando para resetar o histórico de conversação no canal."""
    
    # Resposta já com a personalidade
    if interaction.channel_id in chat_sessions:
        del chat_sessions[interaction.channel_id]
        await interaction.response.send_message(
            "Pronto. Memória limpa, como um reset de fábrica. 😉 Podemos recomeçar.", 
            ephemeral=False
        )
    else:
        await interaction.response.send_message(
            "Minha memória neste canal já estava vazia. 😄", 
            ephemeral=True
        )


# --- Execução da Bot ---

if DISCORD_TOKEN:
    try:
        bot.run(DISCORD_TOKEN)
    except discord.errors.LoginFailure:
        print("\nERRO CRÍTICO: Token do Discord inválido. Verifique o arquivo .env.")
    except Exception as e:
        print(f"\nOcorreu um erro durante a execução: {e}")
else:
    print("\nERRO CRÍTICO: O token DISCORD_TOKEN não foi encontrado no arquivo .env.")