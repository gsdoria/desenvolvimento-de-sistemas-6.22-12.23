using System;

class Program {
  public static void Main (string[] args) {
    int i;
    Console.WriteLine ("Escreva sua idade.");
    i = int.Parse(Console.ReadLine());

    if(i>=5 && i<=7){
      Console.WriteLine("Sua categoria é Infantil A.");
    }
    else if(i<=10){
      Console.WriteLine("Sua categoria é Infantil B.");
    }
    else if(i<=13){
      Console.WriteLine("Sua categoria é Juvenil A.");
    }
    else if(i<=17){
      Console.WriteLine("Sua categoria é Juvenil B.");
    }
    else{
      Console.WriteLine("Sua categoria é Adulto.");
    }
  }
}

/*
INICIO
int i;
escreva "Escreva sua idade."
leia i

se i>=5 && i<=7
  escreva "Sua categoria é Infantil A."
se não se i<=10
  escreva "Sua categoria é Infantil B."
se não se i<=13
  escreva "Sua categoria é Juvenil A."
se não se i<=17
  escreva "Sua categoria é Juvenil B."
se não
  escreva "Sua categoria é Adulto."
fim se
FIM
*/