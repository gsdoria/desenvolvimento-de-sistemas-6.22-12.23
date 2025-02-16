using System;

class Program {
  public static void Main (string[] args) {
    double vm;
    string nome;

    Console.WriteLine("Escreva o valor das vendas mensais.");
    vm = double.Parse(Console.ReadLine());

    Console.WriteLine("Escreva o nome do vendedor.");
    nome = Console.ReadLine();

    if(vm>10000 && vm<=50000){Console.WriteLine(nome);}
    
  }
}

/*
INICIO
var vm: real
var nome: texto

escreva "Escreva o valor das venads mensais."
leia vm

escreva "Escreva o nome do vendedor."
leia nome

se vm>10000 && vm<=50000
  escreva nome
fim se

FIM
*/