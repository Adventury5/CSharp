using System;

class MainClass {
  public static void Main (string[] args) {
    
    int NUM1;
    
    Console.Write ("Digite um numero inteiro: "); 
    NUM1 = int.Parse(Console.ReadLine()) ; 
  
    Console.Write ("A Metade do numero é: " + (NUM1 / 2));

    Console.Write ("\nO Dobro  do numero é: " + (NUM1 * 2));
    
    Console.ReadKey(); 
  }
}