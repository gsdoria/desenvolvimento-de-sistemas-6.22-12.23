import 'dart:io';

void main(){
  Carro carro = new Carro();

  print("Escreva a marca do carro.");
  carro.marca = stdin.readLineSync()!;

  print("Escreva o modelo do carro.");
  carro.modelo = stdin.readLineSync()!;

  print("Escreva o ano do carro.");
  carro.ano = int.parse(stdin.readLineSync()!);

  carro.ligar();
  carro.desligar();
  carro.acelerar();
}


class Carro{

  String marca = '';
  String modelo = '';
  int ano = 0;

  void ligar(){
    print("Ligando o $modelo.");
  }

  void desligar(){
    print("Desligando o $modelo.");
  }

  void acelerar(){
    print("Acelerando o $modelo.");
  }
  
}