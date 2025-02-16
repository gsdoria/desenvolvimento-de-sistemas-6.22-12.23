import 'dart:io';

void conversorCelsiusFarenheit() {
  print("Digite a temperatura em Celsius.");
  var c = double.parse(stdin.readLineSync()!);

  var f = (9 / 5 * c) + 32;

  print("$c°C é equivalente a $f°F");
}