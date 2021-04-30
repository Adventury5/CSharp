using System;

class MainClass {
  public static void Main (string [] args) {
    
    int NUM1; int NUM2;
    
    Console.Write ("Digite um numero inteiro: "); 
    NUM1 = int.Parse(Console.ReadLine()) ; 

    Console.Write ("Digite numero a ser somado: ");
    NUM2 = int.Parse (Console.ReadLine()) ;

    Console.Write ("A soma  dos numeros é: " + (NUM1 + NUM2));
    
    Console.ReadKey(); 
  }
}