import 'dart:io';

void main(){
  Baralho b = Baralho();

  b.criarBaralho();

  b.embaralhar();

  b.distribuir();
}

class Carta{
  String numero = "";
  String naipe = "";
}

class Baralho{
  String n = "A234567890JQK";
  String t = "♤♡◇♧";
  List baralho = [];

  void mostrarBaralho(){
    print('\nMostrando baralho');
    print(baralho);
  }

  void criarBaralho(){
    for(final i in t.split('')){
      for(final j in n.split('')){
        baralho.add( j!="0" ? j+i:"10"+i );
      }
    }
    print("Baralho criado.");
  }

  void embaralhar(){
    baralho.shuffle();
    mostrarBaralho();
    print("Baralho embaralhado.");
  }

  void distribuir(){
    print("\nDistribuindo cartas\n");
    print("Digite quantas cartas devem ser distribuídas");
    int nc = int.parse(stdin.readLineSync()!);

    if (nc<1 || nc>52) print("Digite um número válido para ser distribuído");

    else{
      print("Digite para quantas pessoas devem ser distribuídas");
      int np = int.parse(stdin.readLineSync()!);

      if (np<1 || np*nc>52) print("Digite um número válido para ser distribuído");

      else{
        List sc = baralho.sublist(0, nc);
        String cartas = sc.join(", ");
        print("Suas cartas são $cartas");
      }
    }
  }
  
  
}