using System;

class MainClass {
  public static void Main (string[] args) {
  
  int DIA, MES, ANO;

  Console.WriteLine ("\nInforme o Dia: ");
  DIA = int.Parse(Console.ReadLine());

  Console.WriteLine ("\nInforme o Mês: ");
  MES = int.Parse(Console.ReadLine());

  Console.WriteLine ("\nInforme o Ano: ");
  ANO = int.Parse(Console.ReadLine());

  switch(MES){

    case 01:
    Console.WriteLine("\n" + DIA + " de Janeiro de " + ANO);
    break;

    case 02:
    Console.WriteLine("\n" + DIA + " de Fevereiro de " + ANO);
    break;

    case 03:
    Console.WriteLine("\n" + DIA + " de Março de " + ANO);
    break;

    case 04:
    Console.WriteLine("\n" + DIA + " de Abril de " + ANO);
    break;

    case 05:
    Console.WriteLine("\n" + DIA + " de Maio de " + ANO);
    break;

    case 06:
    Console.WriteLine("\n" + DIA + " de Junho de " + ANO);
    break;

    case 07:
    Console.WriteLine("\n" + DIA + " de Julho de " + ANO);
    break;

    case 08:
    Console.WriteLine("\n" + DIA + " de Agosto de " + ANO);
    break;

    case 09:
    Console.WriteLine("\n" + DIA + " de Setembro de " + ANO);
    break;

    case 10:
    Console.WriteLine("\n" + DIA + " de Outubro de " + ANO);
    break;

    case 11:
    Console.WriteLine("\n" + DIA + " de Novembro de " + ANO);
    break;

    case 12:
    Console.WriteLine("\n" + DIA + " de Dezembro de " + ANO);
    break;

  }
  }
  }