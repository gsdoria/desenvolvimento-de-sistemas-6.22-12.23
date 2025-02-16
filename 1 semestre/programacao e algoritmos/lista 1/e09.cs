using System;

class Program {
  public static void Main (string[] args) {
    double vr, vd, co;

    Console.WriteLine("Escreva a quantidade de dinheiro, em dólares, que tem no cofre.");
    vd = double.Parse(Console.ReadLine());

    Console.WriteLine("Escreva a cotação diária atual do dólar.");
    co = double.Parse(Console.ReadLine());

    vr = vd*co;

    Console.WriteLine("Você tem {0} reais",vr);
  }
}