using System;

class Program {
  public static void Main (string[] args) {
    int s = 0; 
    for(int i=0; i<=100; i+=2){ s += i; } 
    Console.WriteLine(s);
  }
}