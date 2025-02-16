import 'dart:io';
import "dart:math";

void main(){
  Triangulo triangulo = new Triangulo();
  triangulo.perimetroTriangulo();
  triangulo.areaTriangulo();
  
  Circulo circulo = new Circulo();
  circulo.perimetroCirculo();
  circulo.areaCirculo();

  Quadrado quadrado = new Quadrado();
  quadrado.perimetroQuadrado();
  quadrado.areaQuadrado();
}

class FormaGeometrica{
  static double area(double altura, double largura){
    return altura*largura;
  }

  double perimetro(double lado){
    return 4*lado;
  }

}

class Triangulo extends FormaGeometrica{
  @override
  double perimetro(double lado){
    return 3*lado;
  }
  
  void areaTriangulo(){
    print("Calcular área do triângulo.");
    print("Digite o lado do triângulo.");
    double l = double.parse(stdin.readLineSync()!);
    
    double areaT = FormaGeometrica.area(l,l*sqrt(3)/2);
    print("A área de um triângulo com lado $l é $areaT\n");
  }

  void perimetroTriangulo(){
    print("Calcular perímetro do triângulo.");
    print("Digite o lado do triângulo.");
    double l = double.parse(stdin.readLineSync()!);

    double perimetroT = perimetro(l);
    print("O perimetro de um triângulo com lado $l é $perimetroT\n");
  }
}

class Circulo extends FormaGeometrica{
  @override
  double perimetro(double raio){
    return 2*pi*raio;
  }

  void areaCirculo(){
    print("Calcular área do círculo.");
    print("Digite o raio do círculo.");
    double r = double.parse(stdin.readLineSync()!);
    
    double areaC = FormaGeometrica.area(r,pi*r);
    print("A área de um círculo com raio $r é $areaC\n");
  }

  void perimetroCirculo(){
    print("Calcular perímetro do círculo.");    
    print("Digite o raio do círculo.");
    double r = double.parse(stdin.readLineSync()!);

    double perimetroC = perimetro(r);
    print("O perimetro de um círculo com raio $r é $perimetroC\n");
  }
}

class Quadrado extends FormaGeometrica{
  void areaQuadrado(){
    print("Calcular área do quadrado.");
    print("Digite o lado do quadrado.");
    double l = double.parse(stdin.readLineSync()!);
    
    double areaQ = FormaGeometrica.area(l,l);
    print("A área de um quadrado com lado $l é $areaQ\n");
  }

  void perimetroQuadrado(){
    print("Calcular perímetro do quadrado.");
    print("Digite o lado do quadrado.");
    double l = double.parse(stdin.readLineSync()!);

    double perimetroQ = perimetro(l);
    print("O perimetro de um triângulo com lado $l é $perimetroQ\n");
  }
}