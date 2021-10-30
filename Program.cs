using System;

namespace DoadorSangue
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            Console.Clear();
            Console.Beep();
            Console.Write("Digite seu nome : ");
            nome = Console.ReadLine();

            Console.Write("Digite sua idade : ");
            idade = Convert.ToInt32(Console.ReadLine());

            if(idade >= 18 && idade <= 67)
            {
                Console.WriteLine($"\n{nome}, você pode ser doador de sangue");
            }
            else
            {
                Console.WriteLine($"\n{nome}, voce não pode ser doador de sangue");
            }

        }
    }
}
