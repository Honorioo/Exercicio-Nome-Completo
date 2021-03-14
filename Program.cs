using System;

namespace Exercicio_Nome_Completo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Beep();

            String Nome;
            String Sobrenome;
        

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Escreva seu primeiro nome: ");
            Console.ResetColor();
            Nome = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Escreva seu segundo nome: ");
            Console.ResetColor(); 
            Sobrenome = Console.ReadLine();
          
            Console.WriteLine();

            Console.WriteLine($"Nome Completo: {Nome} {Sobrenome}");
            Console.WriteLine($"Nome Completo: {Sobrenome.ToUpper()}, {Nome}");


            

            
        }
    }
}
