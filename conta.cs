using System;
using System.Collections.Generic;
using System.Text;

namespace conta_bancaria
{
    public class Conta
    {
        private String _nome;

        private String _sobrenome;

        public String NomeCompleto
        {
            get
            {
                return _nome + " " + _sobrenome;
            }
        }

        public double Saldo { get; private set; }


        public String Nome { get; set; }
        public int Numero { get; set; }
        public int Agencia { get; set; }
        public long CPF { get; set; }

        public Conta(string nome, string sobreNome)
        {
            _nome = nome;
            _sobrenome = sobreNome;
        }

        public static Conta AchaConta(List<Conta> listaDeContas)
        {
            Console.WriteLine("Informe o numero da conta: ");
            var nConta = Convert.ToDouble(Console.ReadLine());

            foreach (var conta in listaDeContas)
            {
                if (conta.Numero == nConta)
                {
                    return conta;
                }
            }
            Console.WriteLine("Conta nao encontrada:");
            return null;
        }

        public static void CadastrarNovaConta(List<Conta> listaDeContas)
        {
            Console.WriteLine("Cadastre uma nova conta:");


            Console.WriteLine("informe o Nome do Titular:");
            var nome = Console.ReadLine();

            Console.WriteLine("informe o Sobrenome do Titular:");
            var sobreNome = Console.ReadLine();

            var conta = new Conta(nome, sobreNome);

            Console.WriteLine("informe o CPF do Titular (apenas numeros):");
            conta.CPF = Convert.ToInt64(Console.ReadLine());

            conta.Saldo = 0;
            conta.Numero = 1050 + 1 + listaDeContas.Count;
            conta.Agencia = 100;

            listaDeContas.Add(conta);

            Console.WriteLine("Conta numero: " + conta.Numero + " Cadastrada com sucesso.");

        }

        public static void Sacar(List<Conta> listaDeContas)
        {
            var conta = AchaConta(listaDeContas);

            Console.WriteLine("Informe o valor a ser sacado: ");
            var vSaque = Convert.ToDouble(Console.ReadLine());

            if (conta.Saldo >= vSaque)
            {
                conta.Saldo -= vSaque;
                Console.WriteLine("Saque no valor de: " + vSaque + " realizado com sucesso, novo saldo: " + conta.Saldo);
            }
            else Console.WriteLine("Saque no valor de: " + vSaque + " nao realizado, saldo disponivel de:  " + conta.Saldo);
        }

        public static void Depositar(List<Conta> listaDeContas)
        {
            var conta = AchaConta(listaDeContas);

            Console.WriteLine("Informe o valor a ser depositado: ");
            var vDeposito = Convert.ToDouble(Console.ReadLine());

            conta.Saldo += vDeposito;

            Console.WriteLine("Valor de: " + vDeposito + " Realizado com sucesso, valor apos o Deposito: " + conta.Saldo);
        }
        public static void ListarContas(List<Conta> listaDeContas)
        {
            if (listaDeContas.Count == 0)
                Console.WriteLine("nenhuma conta Cadastrada.");
            else
            {
                foreach (var conta in listaDeContas)
                {
                    Console.WriteLine("Conta Numero: " + conta.Numero + " Nome do Titular da conta: " + conta.NomeCompleto);
                }
            }
        }
        public static void VerSaldo(List<Conta> listaDeContas)
        {
            var conta = AchaConta(listaDeContas);

            Console.WriteLine("o Saldo da conta é: " + conta.Saldo);
        }

    }
}
