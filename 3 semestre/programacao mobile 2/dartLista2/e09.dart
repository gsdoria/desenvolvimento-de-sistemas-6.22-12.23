import 'dart:io';

void maioresNotas() {
  print("Digite a primeira nota");
  var n1 = double.parse(stdin.readLineSync()!);
  print("Digite a segunda nota");
  var n2 = double.parse(stdin.readLineSync()!);
  print("Digite a terceira nota");
  var n3 = double.parse(stdin.readLineSync()!);
  print("Digite a quarta nota");
  var n4 = double.parse(stdin.readLineSync()!);

  double maior = n1 > n2
      ? (n1 > n3 ? (n1 > n4 ? n1 : n4) : (n3 > n4 ? n3 : n4))
      : (n2 > n3 ? (n2 > n4 ? n2 : n4) : (n3 > n4 ? n3 : n4));

  print("O menor entre eles é $maior");
}