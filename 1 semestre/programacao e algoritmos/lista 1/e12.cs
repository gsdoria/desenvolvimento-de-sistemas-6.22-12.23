using System;

class Program {
  public static void Main (string[] args) {
    float A, B, C, D;

    A = 2;
    B = 4;

    C = (A+B) * B;
    D = C*B / (A*A);
    A = D / (C+B);
    B = B + A;

    Console.WriteLine("A variavel A vale: " + A);
    Console.WriteLine("A variavel B vale: " + B);
    Console.WriteLine("A variavel C vale: " + C);
    Console.WriteLine("A variavel D vale: " + D);
    
  }
}