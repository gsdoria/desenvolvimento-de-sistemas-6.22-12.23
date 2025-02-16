import 'dart:io';

void main() {
  Calculadora calculadora = Calculadora();

  int n = 1;
  List l = [];

  for (int i = 1; i <= n; i++) {
    print("Digite o ${i}º número.");
    l.add(double.parse(stdin.readLineSync()!));

    print("Deseja digitar mais um número? (s, n)");
    if (["s", "S"].contains(stdin.readLineSync())) n++;
  }

  print("Qual operação gostaria de realizar com os números? (+, -, *, /)");

  String op = stdin.readLineSync()!;

  switch (op) {
    case "+":
      print("O resultado de ${l.join(" $op ")} é ${calculadora.soma(l)}");
      break;
    case "-":
      print("O resultado de ${l.join(" $op ")} é ${calculadora.subtracao(l)}");
      break;
    case "*":
      print(
          "O resultado de ${l.join(" $op ")} é ${calculadora.multiplicao(l)}");
      break;
    case "/":
      print("O resultado de ${l.join(" $op ")} é ${calculadora.divisao(l)}");
      break;
    default:
      print("Operação inválida.");
      break;
  }
}

class Calculadora {
  double soma(List numeros) {
    return numeros.reduce((a, b) => a + b).toDouble();
  }

  double subtracao(List numeros) {
    return numeros.reduce((a, b) => a - b).toDouble();
  }

  double multiplicao(List numeros) {
    return numeros.reduce((a, b) => a * b).toDouble();
  }

  double divisao(List numeros) {
    if ([-1, 0].contains(numeros.indexOf(0))) {
      return numeros.reduce((a, b) => a / b).toDouble();
    }

    throw new Exception('Não é possível dividir por zero.');
  }
}
