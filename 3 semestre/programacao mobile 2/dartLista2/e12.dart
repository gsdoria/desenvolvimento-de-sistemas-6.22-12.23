int mdc(int n1, int n2) {
  int a = 1, b = (n1 > n2) ? n1 : n2;

  for (int i = 1; i < b; i++) {
    if (n1 % i == 0 && n2 % i == 0) a = i;
  }
  return a;
}
