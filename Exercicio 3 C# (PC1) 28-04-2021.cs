using System;

class MainClass {
  public static void Main (string[] args) {
    
    float Salario; float Gratificacao; float imposto; 
    
    Console.Write ("\nDigite seu salario-base: "); 
    Salario = float.Parse(Console.ReadLine()) ; 
  
    Gratificacao = (Salario + Salario * 5 / 100);

    Console.Write ("\nApós a gratificação seu Salario é: R$ " + Gratificacao);
    
    imposto = ( Salario * 7 / 100);
    Console.Write ("\nOs Impostos a ser pago é: R$ " + imposto );

    Console.Write ("\nSeu salario final é: R$ " + (Gratificacao - imposto) );
    
    Console.ReadKey(); 
  }
}
