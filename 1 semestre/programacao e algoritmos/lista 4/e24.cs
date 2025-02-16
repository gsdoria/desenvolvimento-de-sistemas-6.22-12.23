using System;

class Program {
  public static void Main (string[] args) {
    double cm, p=0;
    
    Console.Write ("Digite a carga máxima do elevador. ");
    cm = double.Parse(Console.ReadLine());

    for(int i=0; i<5; i++){
      Console.Write ("Digite o peso da {0}ª pessoa de 5. ", i+1);
      p += double.Parse(Console.ReadLine()); }

    if (p>cm) {
      Console.WriteLine("\nO peso máximo foi excedido.");
    } else {
      Console.WriteLine("\nO peso máximo não foi excedido."); }
    
  }
}