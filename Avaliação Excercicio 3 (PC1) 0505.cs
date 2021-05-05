using System;

class MainClass {
  public static void Main (string[] args) {
    float HT; float VH; float PD; float SB; float TD; float SL; 

    Console.Write ("\nDigite suas horas trabalhads: "); HT = float.Parse(Console.ReadLine()); 

    Console.Write ("\nDigite o valor da hora trabalhada: ");
    VH = float.Parse (Console.ReadLine());

    Console.Write ("\nDigite o percentual de desconto: ");
    PD = float.Parse (Console.ReadLine());

    SB = (HT * VH);

    TD = (SB * PD / 100);

    SL = (SB - TD);

    Console.Write ("\nVocê Trabalhou: " + HT + (" Horas"));

    Console.Write ("\nSeu Salário Bruto é: R$" + SB);

    Console.Write ("\nSerá Descontado: R$" + TD);

    Console.Write ("\nSeu Salário Liquido Será: R$" + SL);

    Console.ReadKey();

  }
}
