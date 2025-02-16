import 'dart:io';

void valorDelta() {
  print("Digite o valor de a.");
  var a = double.parse(stdin.readLineSync()!);

  print("Digite o valor de b.");
  var b = double.parse(stdin.readLineSync()!);

  print("Digite o valor de c.");
  var c = double.parse(stdin.readLineSync()!);

  var delta = b * b - 4 * a * c;

  print("O valor de delta é $delta");
}
