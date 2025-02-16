using System;

class Program {
  public static void Main (string[] args) {
    double [] n = new double[3];

    for(int i=0; i<3; i++){
      Console.Write ("Digite um número. ");
      n[i] = int.Parse(Console.ReadLine());
    }

    Array.Sort(n);
    Array.Reverse(n);
    
    Console.WriteLine ("{0} {1} {2}", n[0], n[1], n[2]);
  }
}