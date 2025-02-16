import 'dart:io';

primosAteN() {
  print("Digite o limite máximo.");
  int n = int.parse(stdin.readLineSync()!);
  var l = [];

  for (int i = 2; i < n; i++) {
    var a = 0;
    for (int j = 2; j < i; j++) {
      if (i % j == 0) {
        a = 1;
        break;
      }
    }
    if (a == 0) {
      l.add(i);
    }
  }
  print("Os números primos até $n são:");
  for (int i in l) {
    print(i);
  }
}
