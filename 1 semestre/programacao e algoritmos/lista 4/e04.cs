using System;

class Program {
  public static void Main (string[] args) {
    double[] i = new double[12], s = new double[12];
    double it=0, im=0, ih=0, mh=0, mm=0;

    for(int j=0; j<12; j++){
      Console.Write ("\nDigite sua idade. ");
      i[j] = double.Parse(Console.ReadLine());

      it += i[j];

      Console.Write ("Digite 0 para \"homem\" ou 1 para \"mulher\". ");
      s[j] = double.Parse(Console.ReadLine());

      if(s[j] == 0){ mh++; ih += i[j];}
      if(s[j] == 1){ mm++; im += i[j];}
    }

    ih /= mh;
    im /= mm;
    it /= 12;

    Console.WriteLine("A idade média de todos é de {0:F2} anos.", it);
    Console.WriteLine("A idade média dos homens é de {0:F2} anos.", ih);
    Console.WriteLine("A idade média das mulheres é de {0:F2} anos.", im);
  }
}