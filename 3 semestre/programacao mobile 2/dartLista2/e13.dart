import 'dart:io';

void numerosPerfeitos() {
  print("Digite o limite máximo.");
  int n = int.parse(stdin.readLineSync()!);
  var l = [], p = 0;

  for (int i = 1; i < n; i++) {
    p = 0;
    for (int j = 1; j < i; j++) {
      if (i % j == 0) {
        p += j;
      }
    }
    if (p == i) {
      l.add(i);
    }
  }
  print("Os números perfeitos menores que $n são: $l");
}
