using System;

namespace ProjEstudoOB {
    internal class Program {

        static String NomeP() {
            String nomePessoa = "";
            Console.Write("Nome: ");
            return nomePessoa = Console.ReadLine();
        }

        static String DateNascP() {
            String dtnNasc;
            Console.Write("Data de Nascimento: ");
            return dtnNasc = Console.ReadLine();

        }

        static int cpfP() {
            int cpfPessoa;
            Console.Write("CPF: ");
            return cpfPessoa = int.Parse(Console.ReadLine());
        }

        static int telP() {
            int telPessoa;
            Console.Write("Telefone: ");
            return telPessoa = int.Parse(Console.ReadLine());
            
        }

        static void Main(string[] args) {

            Pessoa pessoa1 = new Pessoa(NomeP(), DateNascP(), cpfP(), telP());
            Console.Clear();
            Pessoa pessoa2 = new Pessoa(NomeP(), DateNascP(), cpfP(), telP());
            Console.Clear();
            Pessoa pessoa3 = new Pessoa(NomeP(), DateNascP(), cpfP(), telP());
            Console.Clear();

            Console.WriteLine(pessoa1.ToString());
            Console.WriteLine(pessoa2.ToString());
            Console.WriteLine(pessoa3.ToString());

        }
    }
}
