using System;
using System.Collections.Generic;

namespace conta_bancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            var operacoes = new Operacoes();
            var listaDeContas = new List<conta>();
            var conta = new conta();

            var op = "";

            do
            {
                Console.WriteLine("Informe a operação a ser realizada: \"s\" para saque, \"d\" para deposito,");
                Console.WriteLine("\"c\" para cadastrar uma nova conta, \"sair\" para sair");

                op = Console.ReadLine().ToLower();

                if (op == "c")
                    conta.CadastrarNovaConta(listaDeContas);

                else if (op == "s")
                {
                    operacoes.sacar(listaDeContas);
                }
                else if (op == "d")
                {
                    operacoes.depositar(listaDeContas);
                }
            }
            while (op != "sair");
        }
    }
}
