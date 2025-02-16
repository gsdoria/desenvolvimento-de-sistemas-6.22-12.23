import 'dart:io';

void main(){
  Estoque estoque = new Estoque();
  
  estoque.adicionarProduto();
  estoque.listarProdutos();
  estoque.adicionarProduto();
  estoque.listarProdutos();
  estoque.removerProduto();
  estoque.listarProdutos();
}


class Produto{
  String nome = "";
  double preco = 0;
  int quantidade = 0;
}

class Estoque{

  List l = [];

  void adicionarProduto(){
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
  }

  void listarProdutos(){
    for ( int i=0; i<l.length; i++ ){
      print("\n${i+1}º produto:");
      print("\tNome do produto: ${l[i].nome}");
      print("\tPreço do produto: ${l[i].preco}");
      print("\tQuantidade do produto: ${l[i].quantidade}\n");
    }
  }

  void removerProduto(){
    print("Digite o índice do produto.");
    l.removeAt(int.parse(stdin.readLineSync()!)-1);
    print("Produto removido");
  }
}