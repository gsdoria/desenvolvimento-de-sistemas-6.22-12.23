/*
– Faça um algoritmo que receba 10 idades, pesos e alturas, calcule e mostre:
• A média das idades das 10 pessoas;
• A quantidade de pessoas com peso superior a 90 quilos e altura inferior a 1.50;
• A porcentagem de pessoas com idade entre 10 e 30 anos entre as pessoas que medem mais de
1.90.
*/

using System;

class Program {
  public static void Main (string[] args) {
    double [] i = new double[10], p = new double[10], a = new double[10];
    double m=0, q=0, po=0;

    for(int j = 0; j<10; j++){
      Console.Write ("\nEscreva sua idade. ");
      i[j] = double.Parse(Console.ReadLine());

      m += i[j];

      Console.Write ("Escreva seu peso em kg. ");
      p[j] = double.Parse(Console.ReadLine());

      Console.Write ("Escreva sua altura em cm. ");
      a[j] = double.Parse(Console.ReadLine());

      if( (i[j]>=10 && i[j]<=30) && (a[j]>190) ){ po++; }

      if( (p[j]>90) && (a[j]<150 ) ){ q++; }
    }
    
    m /= q;

    po *= 100/q;

    Console.WriteLine("A média das idades é de {0} anos.", m);
    Console.WriteLine("{0:F1}% pessoas entre 10 a 30 anos com mais de 1.90m.", po);
    Console.WriteLine("Há {0} pessoas com mais de 90kg e menos de 1.50m.", q);
    
    
  }
}

