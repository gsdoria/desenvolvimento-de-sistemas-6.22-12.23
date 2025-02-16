using System;

class Program {
  public static void Main (string[] args) {
    double d = 520, p = 1.5, kml = 12;
    Console.WriteLine ("Maria terá de por {0:F2}L de gasolina e gastará R${1:F2} com isso.", d/kml, d*p/kml);
  }
}