import 'dart:io';

void main() {
  AgendaDeTarefas adt = new AgendaDeTarefas();

  adt.adicionarTarefa();
  adt.listarTarefas();

  adt.adicionarTarefa();
  adt.listarTarefas();

  adt.fecharTarefa();
  adt.listarTarefas();

}


class Tarefa{
  String descricao = '';
  String dataVencimento = '';
  String status = '';  
}

class AgendaDeTarefas{
  List lista = [];

  void adicionarTarefa(){
    Tarefa tarefa = new Tarefa();

    print("Digite a descrição da tarefa.");
    tarefa.descricao = stdin.readLineSync()!;

    print("Digite a data de vencimento da tarefa.");
    tarefa.dataVencimento = stdin.readLineSync()!;

    print("Digite o status da tarefa (aberta(a), em curso(c) ou fechada(f)).");
    tarefa.status = stdin.readLineSync()!;

    lista.add(tarefa);
    
  }

  void fecharTarefa(){
    print("Digite o indíce da tarefa que deseja marcar como fechada.");
    lista[int.parse(stdin.readLineSync()!)-1].status = "f";
  }

  void listarTarefas(){
    for(int i=0; i<lista.length; i++){
      print("Tarefa ${i+1}:");
      print("\tDescrição: ${lista[i].descricao}");
      print("\tData de vencimento: ${lista[i].dataVencimento}");
      print("\tStatus: ${lista[i].status}\n");
    }
  }
}