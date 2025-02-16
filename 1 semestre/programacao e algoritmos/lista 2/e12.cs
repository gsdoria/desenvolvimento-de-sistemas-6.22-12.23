using System;

class Program {
  public static void Main (string[] args) {
    double t;
    Console.WriteLine ("Escreva a temperatura em graus celsius.");
    t = double.Parse(Console.ReadLine());

    if(t<100){
      Console.WriteLine("Temperatura muito baixa.");
    }else if(t<=200){
      Console.WriteLine("Temperatura baixa.");
    }else if(t<500){
      Console.WriteLine("Temperatura normal.");
    }else{
      Console.WriteLine("Temperatura muito alta.");
    }
  }
}

/*INICIO
var t: real

escreva "Escreva a temperatura em graus celsius."
leia t

se t<100
  escreva "Temperatura muito baixa."
se não se t<=200
  escreva "Temperatura baixa."
se não se t<500
  escreva "Temperatura normal."
se não
  escreva "Temperatura muito alta."
fim se

FIM*/