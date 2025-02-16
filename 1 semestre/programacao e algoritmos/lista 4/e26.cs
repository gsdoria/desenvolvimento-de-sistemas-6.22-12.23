using System;

class Program {
  public static void Main (string[] args) {
    string nome;
    double sb, nd, sl, inss;
    
    Console.Write ("Escreva seu nome. ");
    nome = Console.ReadLine();

    Console.Write ("Digite seu salário bruto. ");
    sb = double.Parse(Console.ReadLine());

    Console.Write ("Digite seu número de dependentes. ");
    nd = double.Parse(Console.ReadLine());

    inss = sb <= 300 ? sb*0.08 : sb <= 700 ? sb*0.09 : sb*0.1;

    sl = sb - inss + 15*nd + 40 + 100;

    Console.WriteLine("\nO salário bruto de {0} será de R${1}.", nome, sl);
  }
}