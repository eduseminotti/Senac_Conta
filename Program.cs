using System;
using System.Collections.Generic;

namespace conta_bancaria
{
    class Program
    {
        static void Main(string[] args)
        {

            var listaDeContas = new List<Conta>();

            var op = "";

            do
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Informe a operação a ser realizada: \"s\" para saque, \"d\" para deposito,");
                Console.WriteLine("\"c\" para cadastrar uma nova conta, \"L\" para listar as contas cadastradas, \"E\" para ver o saldo da conta, \"sair\" para sair");

                op = Console.ReadLine().ToLower();

                if (op == "c")
                    Conta.CadastrarNovaConta(listaDeContas);

                else if (op == "s")
                    Conta.Sacar(listaDeContas);

                else if (op == "d")
                    Conta.Depositar(listaDeContas);

                else if (op == "l")
                    Conta.ListarContas(listaDeContas);

                else if (op == "e")
                    Conta.VerSaldo(listaDeContas);
            }
            while (op != "sair");
        }
    }
}
