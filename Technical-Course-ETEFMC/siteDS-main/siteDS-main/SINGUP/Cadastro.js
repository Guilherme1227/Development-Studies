import express from 'express';
import sqlite3 from "sqlite3";
import { open } from "sqlite";
import bodyParser from 'body-parser';

const app = express();
const PORT = 3000;

// Middleware para servir arquivos estáticos
app.use(express.static('c:/Users/User/Desktop/siteDS/SINGUP'));

// Middleware para parsear o corpo das requisições
app.use(bodyParser.urlencoded({ extended: true }));
app.use(bodyParser.json());

// Função para criar e salvar usuário
async function CreateAndSaveUser (nome, email, senha) {
    const db = await open({
        filename: "./banco.db",
        driver: sqlite3.Database,
    });

    // Cria a tabela se não existir
    await db.run(`CREATE TABLE IF NOT EXISTS usuarios (id INTEGER PRIMARY KEY, email TEXT UNIQUE, nome TEXT, senha TEXT)`);

    // Verifica se o email já está registrado
    const user = await db.get(`SELECT * FROM usuarios WHERE email = ?`, [email]);
    if (user) {
        return "Este email já está registrado. Por favor, use outro email."; // Retorna mensagem de erro
    }

    // Insere o novo usuário
    await db.run(`INSERT INTO usuarios (email, nome, senha) VALUES (?, ?, ?)`, [email, nome, senha]);
    return null; // Retorna null se o cadastro for bem-sucedido
}

// Rota para servir o HTML
app.get('/', (req, res) => {
    res.sendFile('c:/Users/User/Desktop/siteDS/SINGUP/Cadastro.html'); // Ajuste o caminho conforme necessário
});

// Adiciona um manipulador de eventos para o formulário de cadastro
app.post('/cadastro', async (req, res) => {
    const { nome, email, senha, confirmarSenha } = req.body;

    // Verifica se as senhas coincidem
    if (senha !== confirmarSenha) {
        return res.status(400).send("As senhas não coincidem.");
    }

    // Chama a função para criar e salvar o usuário
    const errorMessage = await CreateAndSaveUser (nome, email, senha);
    if (errorMessage) {
        return res.status(400).send(errorMessage); // Envia a mensagem de erro
    }

    res.send("Usuário cadastrado com sucesso!");
});

// Inicia o servidor
app.listen(PORT, () => {
    console.log(`Servidor rodando em http://localhost:${PORT}`);
});