import 'dart:io';

import 'e01.dart';
import 'e02.dart';
import 'e03.dart';
import 'e04.dart';
import 'e05.dart';
import 'e06.dart';
import 'e07.dart';
import 'e08.dart';
import 'e09.dart';
import 'e10.dart';

import 'e11.dart';
import 'e12.dart';
import 'e13.dart';

int? exercicio = 0;

void escolherExercicio(f) {
  print("\nExercício $exercicio escolhido.\n");
  f();
  print("\nExercício $exercicio terminado.\n\n");
}

void main() {
  int controle = 1;
  do {
    print(
        "Digite o número do exercício que deseja rodar ou 0 caso deseje parar.");
    exercicio = int.tryParse(stdin.readLineSync()!);

    switch (exercicio) {
      case 0:
        print("Terminando...");
        controle = 0;
        break;

      case 1:
        escolherExercicio(ePositivo);
        break;
      case 2:
        escolherExercicio(valorDelta);
        break;
      case 3:
        escolherExercicio(raizes);
        break;
      case 4:
        escolherExercicio(maior2);
        break;
      case 5:
        escolherExercicio(menor2);
        break;
      case 6:
        escolherExercicio(menor3);
        break;
      case 7:
        escolherExercicio(aleatorio1a6);
        break;
      case 8:
        escolherExercicio(conversorCelsiusFarenheit);
        break;
      case 9:
        escolherExercicio(maioresNotas);
        break;
      case 10:
        // print("\nExercício $exercicio escolhido.\n");
        // print("O resultado da função foi ${sePositivo1()}.");
        // print("\nExercício $exercicio terminado.\n\n");
        escolherExercicio(sePositivo1);
        break;
      case 11:
        escolherExercicio(primosAteN);
        break;
      case 12:
        print("\nExercício $exercicio escolhido.\n");

        print("Digite o primeiro número");
        int n1 = int.parse(stdin.readLineSync()!);

        print("Digite o segundo número");
        int n2 = int.parse(stdin.readLineSync()!);

        print("O mdc de $n1 e $n2 é ${mdc(n1, n2)}.");
        print("\nExercício $exercicio terminado.\n\n");
        break;
      case 13:
        escolherExercicio(numerosPerfeitos);
        break;
      default:
        print("\nExercício não encontrado.\n");
        break;
    }
  } while (controle == 1);
}
