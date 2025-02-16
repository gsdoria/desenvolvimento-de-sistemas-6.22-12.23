Skip to content
using System;

class Program {
  public static void Main (string[] args) {
    double i=1, m=0, p=0, pa=0, pb=0, pc=0, pd=0, pe=0;
    string a="";
    
    while(i>0){

      Console.Write("\nDigite sua idade. ");
      i = double.Parse(Console.ReadLine());
      
      if(i>0){

        Console.Write("Digite a classificação que você dá ao filme. ");
        a = Console.ReadLine();

        if("abcde".Contains(a.ToLower())){
          m += i;
          p++;
  
          if(a=="a"){ pa++; }
          else if(a=="b"){ pb++; }
          else if(a=="c"){ pc++; }
          else if(a=="d"){ pd++; }
          else{ pe++; }
        }
        
        else { Console.WriteLine("Classificação inválida."); }
      }
    }

    Console.WriteLine("A média de idade dos clientes é de {0:F2} anos", m/p);
    
    Console.WriteLine("{0}% das pessoas que viram  filme o classificam como A.", (pa/p)*100);
    
    Console.WriteLine("{0}% das pessoas que viram  filme o classificam como B.", (pb/p)*100);
    
    Console.WriteLine("{0}% das pessoas que viram  filme o classificam como C.", (pc/p)*100);
    
    Console.WriteLine("{0}% das pessoas que viram  filme o classificam como D.", (pd/p)*100);
    
    Console.WriteLine("{0}% das pessoas que viram  filme o classificam como E.", (pe/p)*100);
  }
}

/*
INÍCIO

var i=1, m=0, p=0, pa=0, pb=0, pc=0, pd=0, pe=0: reais
var a="": texto
    
enquanto i>0 faça

  escreva "Digite sua idade. "
  leia i
  
  se i>0

    escreva "Digite a classificação que você dá ao filme. "
    leia a

    se "abcde" contêm a
      m += i
      p++

      se a=="a")
        pa++ 
      senão se a=="b"
        pb++
      senão se a=="c"
        pc++
      senão se a=="d"
        pd++
      senão
        pe++
      fim se
    
    senão
      escreva "Classificação inválida."
    fim se

  fim se
fim enquanto

escreva "A média de idade dos clientes é de ", m/p, " anos."

escreva (pa/p)*100), "% das pessoas que viram  filme o classificam como A."

escreva (pb/p)*100), "% das pessoas que viram  filme o classificam como B."

escreva (pc/p)*100), "% das pessoas que viram  filme o classificam como C."

escreva (pd/p)*100), "% das pessoas que viram  filme o classificam como D."

escreva (pe/p)*100, "% das pessoas que viram  filme o classificam como E."

FIM
*/
Results of your code will appear here when you run
Default
Workflows
Enable "Accessible Terminal" in Workspace Settings to use a screen reader with the shell.
