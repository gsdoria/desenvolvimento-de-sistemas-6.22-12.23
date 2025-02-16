using System;

class Program {
  public static void Main (string[] args) {
    double c, p=1;
    
    while(p>0){
      Console.Write ("Escreva o preço do produto. ");
      p = double.Parse(Console.ReadLine());

      if (p>0) {
        
        Console.Write ("Escreva o código do produto. ");
        c = double.Parse(Console.ReadLine());

        if (c==1) { 
          Console.WriteLine("\nO pagamento será à vista em dinheiro ou cheque e terá 10% de desconto. O valor será de R${0:F2}.\n", p*0.9); }
        else if (c==2) {
          Console.WriteLine("\nO pagamento será à vista com cartão de crédito e terá 5% de desconto. O valor será de R${0:F2}.\n", p*0.95); }
        else if (c==3) { 
          Console.WriteLine("\nO pagamento será em 2 vezes. O valor será de R${0:F2}.\n", p/2); }
        else if (c==4) { 
          Console.WriteLine("\nO pagamento será em 3 vezes e terá um acréscimo de 10%. O valor será de R${0:F2}.\n", p*1.1/3); }
        
        else { Console.WriteLine("\nCódigo inválido.\n"); }
        
            }
      
          }
  }
}

/*
INÍCIO

double c, p=1;
    
enquanto p>0 faça
  escreva "Escreva o preço do produto."
  leia p

  se p>0
    escreva "Escreva o código do produto."
    leia c

    se c==1
      escreva "O pagamento será à vista em dinheiro ou cheque e terá 10% de desconto. O valor será de R$", p*0.9, "."
    senão se c==2
      escreva "O pagamento será à vista com cartão de crédito e terá 5% de desconto. O valor será de R$", p*0.95, "."
    senão se c==3
      escreva "O pagamento será em 2 vezes. O valor será de R$",p/2,"."
    senão se c==4
      escreva "O pagamento será em 3 vezes e terá um acréscimo de 10%. O valor será de R$", p*1.1/3, "."
    senão 
      escreva "Código inválido."
    fim se
  fim se
fim enquanto


FIM
*/