using System;

class Program {
  public static void Main (string[] args) {
    for(double i=1; i<=50; i++){
      Console.WriteLine ("A temperatura em Celsius relativa a {0}°F é de {1:F2}°C. \n",i ,((i-32)*5)/9 ); }
  }
}

/*
INICIO
para i de 1 até 50 passo 1 faça
  escreva "A temperatura em Celsius relativa a ", i, "°F  é de ", ((i-32)*5)/9, "°C. "
fim para
FIM
*/