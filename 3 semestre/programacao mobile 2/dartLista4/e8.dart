import 'dart:io';

void main(){
  RedeSocial rs = new RedeSocial();

  rs.cadastro();
  rs.cadastro();
  rs.cadastro();

  rs.listarUsuarios();

  rs.adicionarAmigo();
  rs.adicionarAmigo();

  rs.removerAmigo();

  rs.listarAmigos();
}


class Usuario{
  int id = 0;
  String nome = "";
  int idade = 0;
  List listaDeAmigos = [];
}


class RedeSocial{
  List l = [];

  dynamic checarUsuario(int idUsuario){

    bool usuarioExiste = false;

    dynamic u;
    
    for (final i in l){
      if (i.id == idUsuario){ 
        usuarioExiste = true;
        u = i;
        break;
      } 
    }

    if (usuarioExiste) {return [true, u];}
    
    print("Usuário não encontrado.\n");
    return [false,u];
  }
  
  void cadastro(){
    Usuario u = new Usuario();

    u.id = l.isEmpty ? 1 : l.last.id + 1;

    print("\nCadastro.");
    print("Escreva o nome do usuário.");
    u.nome = stdin.readLineSync()!;
    
    print("Digite a idade do usuário.");
    u.idade = int.parse(stdin.readLineSync()!);

    l.add(u);
  }

  void listarUsuarios(){
    print("\nListar usuários.");
    for ( int i=0; i<l.length; i++ ){
      print("${i+1}º usuário:");
      print("\nId do usuário: ${l[i].id}");
      print("\tNome do usuário: ${l[i].nome}");
      print("\tIdade do produto: ${l[i].idade}");
      print("\tLista de amigos: ${l[i].listaDeAmigos}\n");
    }
  }

  void adicionarAmigo(){
    print("\nAdicionar amigo.");
    print("Digite seu id.");
    int idUsuario = int.parse(stdin.readLineSync()!);

    dynamic a = checarUsuario(idUsuario);
    if (a[0]) {
      print("Escreva o id do amigo que deseja adicionar.");
      int idAmigo = int.parse(stdin.readLineSync()!);

      dynamic b = checarUsuario(idAmigo);
      if (b[0]) {
        
        a[1].listaDeAmigos.add( b[1] );
        print("${b[1].nome} foi adicionado como seu amigo.");
      }
    }
  }

  void removerAmigo(){
    print("\nRemover amigo.");
    print("Escreva seu id.");
    int idUsuario = int.parse(stdin.readLineSync()!);
    
    dynamic a = checarUsuario(idUsuario);
    if (a[0]) {
      print("Escreva o id do amigo que deseja remover.");
      int idAmigo = int.parse(stdin.readLineSync()!);
      
      dynamic b = checarUsuario(idAmigo);
      if (b[0]) {
        a[1].listaDeAmigos.remove(b[1]);
        print("${b[1].nome} foi removido de sua lista de amigos.");
      } else print("Este usuário não faz parte da sua lista de amigos.");
        
    }
  }

  void listarAmigos(){
    print("\Listar amigos.");
    print("Escreva seu id.");
    int idUsuario = int.parse(stdin.readLineSync()!);

    dynamic a = checarUsuario(idUsuario);
    if (a[0]) {
      print("Lista de amigos de ${a[1].nome}:");
      int j = 1;
      for ( final i in a[1].listaDeAmigos){
        print("\n${j}º amigo:");
        print("\tId: ${i.id}");
        print("\tNome: ${i.nome}");
        j++;
      }
    }
  }
}