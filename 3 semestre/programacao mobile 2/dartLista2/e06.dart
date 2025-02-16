import 'dart:io';

void menor3() {
  print("Digite o primeiro número");
  var n1 = double.parse(stdin.readLineSync()!);
  print("Digite o segundo número");
  var n2 = double.parse(stdin.readLineSync()!);
  print("Digite o terceiro número");
  var n3 = double.parse(stdin.readLineSync()!);

  var menor = n1 < n2
      ? n1 < n3
          ? n1
          : n3
      : n2 < n3
          ? n2
          : n3;
  print("O menor entre eles é $menor");
}
