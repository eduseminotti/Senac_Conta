using System;
using System.Collections.Generic;
using System.Text;

namespace conta_bancaria
{
    public class conta
    {

        public String Nome { get; set; }
        public int Numero { get; set; }
        public int Agencia { get; set; }
        public long CPF { get; set; }
        public double Saldo { get; set; }

        public conta AchaConta(List<conta> listaDeContas)
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

        public List<conta> CadastrarNovaConta(List<conta> listaDeContas)
        {
            Console.WriteLine("Cadastre uma nova conta:");

            var conta = new conta();
            conta.Saldo = 0;
            Console.WriteLine("informe o Nome do Titular:");
            conta.Nome = Console.ReadLine();
            conta.Numero = 1050 + 1 + listaDeContas.Count;
            conta.Agencia = 100;

            Console.WriteLine("informe o CPF do Titular (apenas numeros):");
            conta.CPF = Convert.ToInt64(Console.ReadLine());

            listaDeContas.Add(conta);

            Console.WriteLine("Conta numero: " + conta.Numero + " Cadastrada com sucesso.");

            return listaDeContas;
        }

    }
}
