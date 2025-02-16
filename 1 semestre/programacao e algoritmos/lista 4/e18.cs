//Escreva um algoritmo para criar um programa de ajuda para vendedores. A partir de um valor total recebido do teclado, mostrar: o total a pagar com desconto de 10%;o valor de cada parcela, no parcelamento de 3 x sem juros; a comissão do vendedor, no caso da venda ser a vista (5% sobre o valor com desconto ) a comissão do vendedor, no caso da venda ser parcelada (5% sobre o valor total)

using System;

class Program {
  public static void Main (string[] args) {
    double v;
    
    Console.Write ("Escreva o valor recebido. ");
    v = double.Parse(Console.ReadLine());

    Console.WriteLine ("\nO valor com 10% de desconto é de R${0}.", v*0.9);

    Console.WriteLine ("O valor de cada parcela com 3x sem juros é de R${0:F2}.",v/3);
    
    Console.WriteLine ("O valor da comissão do vendedor a vista é de R${0}.",v*0.9*0.05);

    Console.WriteLine ("O valor da comissão do vendedor com 3x sem juros é de R${0}.",v *0.05);
  }
}