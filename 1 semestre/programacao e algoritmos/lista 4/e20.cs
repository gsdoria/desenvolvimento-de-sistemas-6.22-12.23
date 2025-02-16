using System;

class Program {
  public static void Main (string[] args) {
    int pd, pm, ud, um;
    
    Console.Write ("Digite o menor dia. "); pd = int.Parse(Console.ReadLine());

    Console.Write ("Digite o menor mês. "); pm = int.Parse(Console.ReadLine());

    Console.Write ("Digite o maior dia. "); ud = int.Parse(Console.ReadLine());

    Console.Write ("Digite o maior mês. "); um = int.Parse(Console.ReadLine());


    pm *= 30; um *= 30;

    pd += pm; ud += um;DD/MM

    ud -= pd;

    Console.WriteLine("A distância das datas é de {0} dias.", ud);
  }
}