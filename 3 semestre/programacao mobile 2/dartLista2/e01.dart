import 'dart:io';

void ePositivo() {
  print("Digite um número.");
  double n = double.parse(stdin.readLineSync()!);

  print(n < 0
      ? "$n não é positivo."
      : n == 0
          ? "$n é 0."
          : "$n é positivo.");
}
