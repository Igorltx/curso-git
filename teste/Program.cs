using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] vect = new string[10];
            Console.WriteLine("Olá");
            Console.WriteLine("Como vai?");
            Console.WriteLine("Estou aprendendo C#");
            Console.WriteLine();
            Console.Write("Digite 7 coisas aí: ");
            for (int i = 1; i < 8; i++)
            {
                Console.Write($"#{i} :");
                vect[i] = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("Bora fazer um cadastro?");
            Console.WriteLine("Quantos cadastros serão realizados?");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Cadastro cad;
            for (int i = 1; i <= n; i++)
            {
                int id = i;
                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o email: ");
                string email = Console.ReadLine();
                cad = new Cadastro(id, nome, email);
                Console.WriteLine();
                Console.WriteLine(cad);
                Console.WriteLine();
            }           
        }
    }
}
