using System;
using System.Collections.Generic;
using System.Text;

namespace conta_bancaria
{
    public class Operacoes
    {
        conta classConta = new conta();

        public void sacar( List<conta> ListContas)
        {
            var conta = classConta.AchaConta(ListContas);
                      
            Console.WriteLine("Informe o valor a ser sacado: ");
            var vSaque = Convert.ToDouble(Console.ReadLine());        


            if (conta.Saldo >= vSaque)
            {
                conta.Saldo -= vSaque;
                Console.WriteLine("Saque no valor de: " + vSaque + " realizado com sucesso, novo saldo:" + conta.Saldo);
            }
            else Console.WriteLine("Saque no valor de: " + vSaque + " nao realizado, saldo de:  " + conta.Saldo + " insuficinte.");          
        }
        public void depositar(List<conta> ListContas)
        {
            var conta = classConta.AchaConta(ListContas);

            Console.WriteLine("Informe o valor a ser depositado: ");
            var vDeposito = Convert.ToDouble(Console.ReadLine());

            conta.Saldo += vDeposito;

            Console.WriteLine("Valor de: " + vDeposito + " Realizado com sucesso, valor apos o Deposito: " + conta.Saldo);
        }
    }
}
