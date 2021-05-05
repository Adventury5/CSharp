using System;

class MainClass {
  public static void Main (string[] args) {
    int Anos;  int Meses; int Dias; int Mes; int Dia;
    
    Console.Write ("\nInforme Quantos Anos Você Tem: "); 
    Anos = int.Parse(Console.ReadLine()) ; 

    Console.Write ("\nAgora Quantos Meses: "); 
    Meses = int.Parse(Console.ReadLine()) ;
    
    Console.Write ("\nE por fim Quantos Dias: "); 
    Dias = int.Parse(Console.ReadLine()) ;

    Mes = (Anos * 12 + Meses);

    Dia = (Mes * 30 + Dias);

    Console.Write ("\nFaz " + Dia + (" Que Você Nasceu!"));
    
    Console.ReadKey();
  }
}
