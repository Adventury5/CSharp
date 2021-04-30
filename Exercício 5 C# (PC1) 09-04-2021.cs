using System;

class MainClass {
  public static void Main (string[] args) {
    
    int BASE; int ALTURA;
    
    Console.Write ("Informe a Base do seu Triangulo: "); 
    BASE = int.Parse(Console.ReadLine()); 
  
    Console.Write ("Informe a Altura do seu Triangulo: "); 
    ALTURA = int.Parse(Console.ReadLine());

    Console.Write ("A Aréa do seu Triangulo é: " + (BASE * ALTURA / 2));
    
    Console.ReadKey(); 
  }
}