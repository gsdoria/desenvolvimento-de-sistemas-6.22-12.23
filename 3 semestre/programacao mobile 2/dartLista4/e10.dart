import 'dart:io';

void main(){
  CarrinhoDeCompras cdc = CarrinhoDeCompras();

  cdc.iniciarCompra();
}

class Produto{
  String nome = "";
  double preco = 0;
  int quantidade = 0;
}


class CarrinhoDeCompras{
  List l = [];
  int controle = 4;

  void adicionarProduto(){
    print("Adicionando produto");
    Produto p = new Produto();
    print("Escreva o nome do produto.");
    String nome = stdin.readLineSync()!;

    print("Digite o preço do produto.");
    double preco = double.parse(stdin.readLineSync()!);

    print("Digite a quantidade do produto.");
    int quantidade = int.parse(stdin.readLineSync()!);

    p.nome = nome;
    p.preco = preco;
    p.quantidade = quantidade;

    l.add(p);
    print("");
  }

  double calcularTotal(){
    double total = 0;

    for(final i in l){ total += i.preco*i.quantidade; }

    return total;
  }

  void finalizarCompra(){
    print("Finalizando compra.");
    print("O total da compra foi R\$${calcularTotal().toStringAsFixed(2)}");
    
    controle = 0;
  }

  void iniciarCompra(){

    int tipo = 4;
    while (controle != 0){      
      switch (tipo) {
        case 0:
          finalizarCompra();
          break;
        case 1:
          adicionarProduto();
          tipo = 4;
          break;
        case 2:
          print("Calculando total.");
          var t = calcularTotal();
          tipo = 4;
          print("O total atual é de R\$${t.toStringAsFixed(2)}.\n");
          break;
        default:
          print("Digite o que deseja fazer:");
          print("\t0: Finalizar compra.");
          print("\t1: Adicionar produto.");
          print("\t2: Calcular total.");
          tipo = int.parse(stdin.readLineSync()!);
          break;
      }
    }
  }
}