import 'dart:io';
import 'dart:math';
double abs(double n) {
  return n < 0 ? -n : n;
}

void raizes() {
  print("Digite o valor de a.");
  var a = double.parse(stdin.readLineSync()!);

  print("Digite o valor de b.");
  var b = double.parse(stdin.readLineSync()!);

  print("Digite o valor de c.");
  var c = double.parse(stdin.readLineSync()!);

  var equacao = (a != 0 ? "$a*x²" : "") +
      (b != 0
          ? (a != 0 ? (b < 0 ? " - ${abs(b)}*x" : " + $b*x") : "$b*x")
          : "") +
      (c != 0 ? (c < 0 ? " - ${abs(c)}" : " + $c") : "") +
      " = 0.0";

  if (a == 0) {
    if (b == 0) {
      print("Equação inválida");
    } else {
      print("A raíz da equação linear $equacao é ${-c / b}");
    }
  } else {
    var delta = b * b - 4 * a * c;
    if (delta < 0) {
      print("As raízes da equação quadrática $equacao não são reais.");
    } else if (delta == 0) {
      print("A raíz única da equação quadrática $equacao é ${-b / (2 * a)}");
    } else {
      print("As raízes da equação quadrática $equacao são ${(-b + pow(delta, 0.5))/ (2 * a)} e ${(-b - pow(delta, 0.5))/ (2 * a)}");
    }
  }
}