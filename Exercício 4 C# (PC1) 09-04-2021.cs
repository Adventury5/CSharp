using System;

class MainClass {
  public static void Main (string[] args) {
    
    int Nota1; int Nota2; int Nota3;
    
    Console.Write ("Digite a Primeira nota do aluno: "); 
    Nota1 = int.Parse(Console.ReadLine()); 
  
    Console.Write ("Digite a Segunda nota do aluno: "); 
    Nota2 = int.Parse(Console.ReadLine());

    Console.Write ("Digite a Tereceira nota do aluno: "); 
    Nota3 = int.Parse(Console.ReadLine());

    Console.Write ("A Média do aluno é: " + ((Nota1 + Nota2 + Nota3) / 3));
    
    Console.ReadKey(); 
  }
}