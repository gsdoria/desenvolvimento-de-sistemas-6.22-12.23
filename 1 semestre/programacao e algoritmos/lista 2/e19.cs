using System;

class Program {
  public static void Main (string[] args) {
    int dn, mn, an, da, ma, aa, i;
    
    Console.WriteLine ("Escreva o dia de seu nascimento.");
    dn = int.Parse(Console.ReadLine());
    Console.WriteLine ("Escreva o número do mês de seu nascimento.");
    mn = int.Parse(Console.ReadLine());
    Console.WriteLine ("Escreva o ano de seu nascimento.");
    an = int.Parse(Console.ReadLine());

    Console.WriteLine ("Escreva o dia atual.");
    da = int.Parse(Console.ReadLine());
    Console.WriteLine ("Escreva o número do mês atual.");
    ma = int.Parse(Console.ReadLine());
    Console.WriteLine ("Escreva o ano atual.");
    aa = int.Parse(Console.ReadLine());

    i = aa-an;
    if(ma<mn){i--;}
    if(da<dn){i--;}

    Console.WriteLine("Você tem {0} anos.", i);
  }
}

/*
INICIO
var dn, mn, an, da, ma, aa, i: inteiro
    
escreva "Escreva o dia de seu nascimento."
leia dn
escreva "Escreva o número do mês de seu nascimento."
leia mn
escreva "Escreva o ano de seu nascimento."
leia an

escreva "Escreva o dia atual."
leia da
escreva "Escreva o número do mês atual."
leia ma
escreva "Escreva o ano atual."
leia aa

i = aa-an
se ma<mn 
  i = i-1
se da<dn
  i = i-1

escreva "Você tem ",i ," anos"
FIM
*/