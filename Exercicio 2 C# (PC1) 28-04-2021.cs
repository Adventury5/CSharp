using System;

class MainClass {
  public static void Main (string[] args) {
    
    float Preco; float Aumento;
    
    Console.Write ("\nDigite um numero inteiro: "); 
    Preco = float.Parse(Console.ReadLine()) ; 
  
    Console.Write ("\nQuantos porcentos o preço aumentará? ");
    Aumento = float.Parse(Console.ReadLine());

    Console.Write ("\nApós o Aumento o Preço é: " + (Preco + Preco * Aumento / 100));

    
    Console.ReadKey(); 
  }
}
