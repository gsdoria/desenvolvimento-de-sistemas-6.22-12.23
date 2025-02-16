using System;

class Program {
  public static void Main (string[] args) {
    double pe, cp;
    Console.Write ("Escreva o preço da etiqueta. ");
    pe = double.Parse(Console.ReadLine());
    
    Console.Write ("Escreva o código da condição de pagamento. ");
    cp = double.Parse(Console.ReadLine());

    if (cp==1){ 
      Console.WriteLine("O pagamento será à vista em dinheiro ou cheque e terá 10% de desconto. O valor será de R${0}.",pe*0.9);}
    else if (cp==2){ 
      Console.WriteLine("O pagamento será à vista com cartão de crédito e terá 5% de desconto. O valor será de R${0}.",pe*0.95);}
    else if (cp==3){ 
      Console.WriteLine("O pagamento será em 2 vezes. O valor será de R${0}.",pe/2);}
    else if (cp==4){ 
      Console.WriteLine("O pagamento será em 3 vezes e terá um acréscimo de 10%. O valor será de R${0}.",pe*1.1/3);}
    else Console.WriteLine("Código inválido.");
  }
}

/*
INÍCIO
var pe, cp: reais
escreva "Escreva o preço da etiqueta."
leia pe

escreva "Escreva o código da condição de pagamento."
leia cp

se cp==1
  escreva "O pagamento será à vista em dinheiro ou cheque e terá 10% de desconto. O valor será de R$", pe*0.9, "."
senão se cp==2
  escreva "O pagamento será à vista com cartão de crédito e terá 5% de desconto. O valor será de R$", pe*0.95, "."
senão se cp==3
  escreva "O pagamento será em 2 vezes. O valor será de R$", pe/2, "."
senão se cp==4
  escreva "O pagamento será em 3 vezes e terá um acréscimo de 10%. O valor será de R$", pe*1.1/3, "."
senão
  escreva "Código inválido."
fim se
FIM
*/