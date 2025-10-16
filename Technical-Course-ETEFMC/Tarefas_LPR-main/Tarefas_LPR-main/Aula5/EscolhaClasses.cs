
using System;
class HelloWorld {
  static void Main() {
    
    int chose;
    
    Console.WriteLine("Selecione sua classe: \nGuerreira = 1 \nMago = 2 \nArqueira = 3");
    chose = Convert.ToInt32(Console.ReadLine());
    
    switch (chose) {
  case 1:
    Console.WriteLine("Sua classe é guerreira, possui ataque pesado e defesa total.");
    break;
  case 2:
    Console.WriteLine("Sua classe é mago, possui bola fogo e escudo de gelo.");
    break;
  case 3:
    Console.WriteLine("Sua classe é mago, possui flecha Precisa, disparo Triplo");
    break;
      default:
    Console.WriteLine("Selecione uma opição valida.");
    break;
 }
 Console.WriteLine("\nAperte qualquer tecla para continuar:");
 Console.ReadKey();
}
}