using System;

class Program {
  public static void Main (string[] args) {
    double a,b;
    
    Console.WriteLine ("Escreva o valor de A.");
    a=double.Parse(Console.ReadLine());

    Console.WriteLine ("Escreva o valor de B.");
    b=double.Parse(Console.ReadLine());

    if(a==b){
      Console.WriteLine("A soma deles é igual a "+(a+b)+".");
    }else if(a>b){
      Console.WriteLine("A subtração deles é igual a "+(a-b)+".");
    }else{
      Console.WriteLine("A subtração deles é igual a "+(b-a)+".");
    }
  }
}

/*
INICIO
var a,b: reais

escreva "Escreva o valor de A."
leia a
escreva "Escreva o valor de B."
leia b

se a==b
  escreva A soma deles é igual a "+(a+b)+"."
se não se a>b
  escreva "A subtração deles é igual a "+(a-b)+"."
se não
  escreva "A subtração deles é igual a "+(b-a)+"."
fim se

FIM
*/