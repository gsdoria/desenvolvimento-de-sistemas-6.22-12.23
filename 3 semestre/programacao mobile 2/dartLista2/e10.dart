import 'dart:io';

void sePositivo1() {
  print("Digite um número.");
  double n = double.parse(stdin.readLineSync()!);
  int resultado = n > 0 ? 1 : -1;
  print("O resultado é $resultado");
}
