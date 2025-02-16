void main(){
  ContaBancaria conta = new ContaBancaria();

  conta.logarConta(1234);

  conta.depositar(1000);
  conta.verficarSaldo();
  conta.sacar(400);
  conta.verficarSaldo();

}


class ContaBancaria {

  int numeroConta = 0;
  double saldo = 0;

  void logarConta(int n){
    numeroConta = n;
  }
  
  void verficarSaldo(){
    print("Seu saldo é de R\$${saldo.toStringAsFixed(2)}.\n");
  }

  void depositar(double n){
    double saldoAntigo = saldo;

    saldo += n;

    print("Depósito efetuado.");
    print("Saldo antigo: R\$${saldoAntigo.toStringAsFixed(2)}");
    print("Saldo atual: R\$${saldo.toStringAsFixed(2)}");
    print("Valor depositado: R\$${n.toStringAsFixed(2)}\n");
  }

  void sacar(double n){
    double saldoAntigo = saldo;

    saldo -= n;

    print("Saque efetuado.");
    print("Saldo antigo: R\$${saldoAntigo.toStringAsFixed(2)}");
    print("Saldo atual: R\$${saldo.toStringAsFixed(2)}");
    print("Valor sacado: R\$${n.toStringAsFixed(2)}\n");
  }
}