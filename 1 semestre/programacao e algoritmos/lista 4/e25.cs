using System;

class Program {
  public static void Main (string[] args) {
    double v, t;
    
    Console.Write ("Digite 1 para um bilhete unitário, 2 para duplo e 3 para 10 viagens. ");
    t = double.Parse(Console.ReadLine());

    Console.Write ("Digite o valor pago pelo passageiro. ");
    v = double.Parse(Console.ReadLine());

    v = t==1 ? v-1.3 : t==2 ? v-2.6 : t==3 ? v-12 : -1;
    
    Console.WriteLine("\n{0}.", v>1 ? String.Format("O valor do troco será de R${0:F2}",v) : (t!=1 && t!=2 && t!=3) ? "Ticket não reconhecido" : "Valor insuficiente");
    
  }
}