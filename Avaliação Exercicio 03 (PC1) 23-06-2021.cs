using System;

class MainClass {
  public static void Main (string[] args) {
  
  int NUM1, NUM2;
  string OPERA;

  Console.WriteLine ("\nInforme o Primeiro número: ");
  NUM1 = int.Parse(Console.ReadLine());

  Console.WriteLine ("\nInforme o Segundo número: ");
  NUM2 = int.Parse(Console.ReadLine());

  Console.WriteLine ("\nAgora escolha um operador: \n (+) Adição; \n (-) Subtração; \n (/) Divisão; \n (%) Resto.");
  OPERA = Console.ReadLine();

  switch(OPERA){

    case "+":
    Console.WriteLine("\no Resultado é: " + (NUM1 + NUM2));
    break;

    case "-":
    Console.WriteLine("\no Resultado é: " + (NUM1 - NUM2));
    break;

    case "/":
    Console.WriteLine("\no Resultado é: " + (NUM1 / NUM2));
    break;

    case "%":
    Console.WriteLine("\no Resultado é: " + (NUM1 % NUM2));
    break;
  }
  }
  }