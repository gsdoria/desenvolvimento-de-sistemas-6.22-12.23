import 'dart:io'; 

void main(){

  Contato contato = new Contato();
  contato.nome = "josefino";
  print(contato.email);

  LivroDeEnderecos lde = new LivroDeEnderecos();

  lde.adicionarContato();
  lde.listarContatos();
  lde.adicionarContato();
  lde.listarContatos();
  lde.adicionarContato();
  lde.listarContatos();
  lde.removerContato();
  lde.listarContatos();

}

class Contato{
  String nome = '';
  String telefone = '';
  String email = '';  
}

class LivroDeEnderecos{
  List lista = [];

  void listarContatos(){
    for(int i=0; i<lista.length; i++){
      print("Contato ${i+1}:");
      print("\tNome: ${lista[i].nome}");
      print("\tTelefone: ${lista[i].telefone}");
      print("\tEmail: ${lista[i].email}\n");
    }
  }
  
  void adicionarContato(){
    
    Contato contato = new Contato();
    print("Digite o nome do contato.");
    contato.nome = stdin.readLineSync()!;
    
    print("Digite o telefone do contato.");
    contato.telefone = stdin.readLineSync()!;
    
    print("Digite o email do contato.");
    contato.email = stdin.readLineSync()!;

    lista.add( contato );
  }

  void removerContato(){
    print("Digite o índice do contato que deseja remover.");
    int i = int.parse(stdin.readLineSync()!);

    String nome = lista[i-1].nome;
    lista.removeAt(i);
    print("O contato de $nome foi removido.");
    
  }
}