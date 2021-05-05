using System;

class MainClass {
  public static void Main (string[] args) {
   float NUM1; float NUM2;

Console.Write ("\nDigite um numero inteiro: ");

NUM1 = float.Parse(Console.ReadLine()) ;



Console.Write ("\nDigite Outro Numero:?: ");

NUM2 = float.Parse (Console.ReadLine()) ;



Console.Write ("\nO Quadrado do Primeiro Numero é: " + (NUM1 * NUM1));

Console.Write ("\nO Quadrado do Segundo Numero é: " + (NUM2 * NUM2));

Console.ReadKey();
  }
}
