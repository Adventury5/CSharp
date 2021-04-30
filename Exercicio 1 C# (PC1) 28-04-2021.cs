using System;

class MainClass {
  public static void Main (string[] args) {
    
    float NUM1;
    
    Console.Write ("Digite um numero inteiro: "); 
    NUM1 = float.Parse(Console.ReadLine()) ; 
  
    
    Console.Write ("\nO Triplo do Número é: " + (NUM1 * 3));
    
    Console.ReadKey(); 
  }
}