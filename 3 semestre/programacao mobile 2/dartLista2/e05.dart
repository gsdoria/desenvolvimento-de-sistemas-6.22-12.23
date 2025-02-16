import 'dart:io';

void menor2() {
  print("Digite o primeiro número");
  var n1 = double.parse(stdin.readLineSync()!);
  print("Digite o segundo número");
  var n2 = double.parse(stdin.readLineSync()!);

  var menor = n1 > n2 ? n2 : n1;
  print("O menor entre eles é $menor");
}
