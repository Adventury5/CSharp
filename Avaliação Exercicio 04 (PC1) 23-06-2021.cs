using System;

class MainClass {
  public static void Main (string[] args) {
  
  double NOTA1, NOTA2, NOTA3, MED, APROV;

  Console.WriteLine ("\nInforme a Primeira nota: ");
  NOTA1 = double.Parse(Console.ReadLine());

  Console.WriteLine ("\nInforme a Segunda nota: ");
  NOTA2 = double.Parse(Console.ReadLine());

  Console.WriteLine ("\nInforme a Terceira nota: ");
  NOTA3 = double.Parse(Console.ReadLine());

  Console.WriteLine ("\nInforme a média dos exercicios: ");
  MED = double.Parse(Console.ReadLine());

  APROV = (NOTA1 + NOTA2 * 2 + NOTA3 + MED / 7);

  if (APROV >= 9.0){
  Console.WriteLine ("\nConceito: A");
  }

  else if (APROV >= 7.5 && APROV < 9.0){
  Console.WriteLine ("\nConceito: B");
  }

  else if (APROV >= 6.0 && APROV < 7.5){
  Console.WriteLine ("\nConceito: C");
  }

  else if (APROV <6.0){
  Console.WriteLine ("\nConceito: D");
  }
  
  else{
    Console.WriteLine ("\nSem Conceito");
    }
  
  }
  }
  