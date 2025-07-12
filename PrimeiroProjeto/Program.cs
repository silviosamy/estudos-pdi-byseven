using System;
using System.Globalization;


namespace PrimeiroProjeto
{
        class Program {
        static void Main(string[] args) {

            string nome = "Maria";
            int idade = 32;
            double saldo = 10.35784;

            Console.WriteLine("{0} tem {1} anos e o seu saldo é de R${2:F2}", nome, idade, saldo); // Formatação com placeholders
            Console.WriteLine($"{nome} tem {idade} anos e seu saldo é de R${saldo:F2}"); // Interpolação de strings

        }
    }
}
