using System;

class Program {
  public static void Main (string[] args) {
    double a, b, c;
    
    Console.WriteLine ("Escreva o valor de a.");
    a = double.Parse(Console.ReadLine());
    Console.WriteLine ("Escreva o valor de b.");
    b = double.Parse(Console.ReadLine());
    Console.WriteLine ("Escreva o valor de c.");
    c = double.Parse(Console.ReadLine());

    if(a==b || a==c || b==c){
      if(a==b && b==c){ 
        Console.WriteLine("O triângulo é equilátero."); 
      }
      else{
        Console.WriteLine("O triângulo é isósceles."); 
      }
    }
    else{
      Console.WriteLine("O triângulo é escaleno."); 
    }
  }
}

/*
INICIO
double a, b, c;
    
escreva "Escreva o valor de a."
leia a
escreva "Escreva o valor de b."
leia b
escreva "Escreva o valor de c."
leia c

se a==b || a==c || b==c
  se a==b && b==c
    escreva "O triângulo é equilátero."
  se não
    escreva "O triângulo é isósceles."
  fim se
se não
  escreva "O triângulo é escaleno."
fim se
FIM
*/