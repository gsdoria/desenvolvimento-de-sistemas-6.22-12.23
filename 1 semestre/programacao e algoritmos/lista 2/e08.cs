using System;

class Program {
  public static void Main (string[] args) {
    double sal;
    string nf, dep;

    Console.WriteLine("Escreva seu nome.");
    nf = Console.ReadLine();
    
    Console.WriteLine("Escreva seu salário.");
    sal = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite p para produção ou e engenharia.");
    dep = Console.ReadLine();

    if(sal>=1000 && sal<=1500){
      if(dep=="p" || dep=="e"){
        Console.WriteLine("Nome: "+nf+";");
        Console.WriteLine("Salário: "+sal+" reais.");
      }
    }

  }
}

/*
INICIO
var sal: real
var nf, dep: texto

escreva "Escreva seu nome."
leia nf

escreva "Escreva seu salário."
leia sal

escreva "Digite p para produção ou e engenharia."
leia dep

se sal>=1000 && sal<=1500
  se dep=="p" || dep=="e"
    escreva "Nome: ", nf, ";"
    escreva "Salário: ", sal, "."
  fim se
fim se

FIM
*/