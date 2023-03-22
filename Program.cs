using System;
using System.IO;

namespace Tasks
{
    class Program
    {
    
    static void Main()
        
        {


        }
    }
}    
            // IDADE COLOR 
            /*
            Console.Write("Digite sua Idade: ");
            
            int idade = int.Parse(Console.ReadLine());

            if (idade < 18)
            
            {
                Console.BackgroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Sem Permissão");  

            } 
            
            else 
            
            {
                Console.BackgroundColor = ConsoleColor.Green;
                System.Console.WriteLine("Permissão Concedida");
            }

            Console.ResetColor(); 
            */

            // ESCREVER EM TXT 

            /*
             System.Console.WriteLine("Digite seu Nome e Email: ");
            string data = Console.ReadLine();

            string caminho = @"LOG.txt";

            using (StreamWriter writer = File.CreateText(caminho))
            
            {
                writer.WriteLine(data);
            }
            */

            // media de idade
            /*
            int idade1 = 10;
            int idade2 = 12;
            int idade3 = 16;
            int idade4 = 18;
            int idade5 = 19;

            var soma = idade1 + idade2 + idade3 + idade4 + idade5;

            var mediaIdade = soma / 5;
            */

            /*
            List<int> Idades = new List<int>();

            Idades.Add(12);
            Idades.Add(15);
            Idades.Add(18);

            var idadesMaiores10 = 0;

            foreach (var Idade in Idades)
            {
                if (Idade > 10)
                {
                    idadesMaiores10++;
                }
            }

            System.Console.WriteLine("Values are: " + idadesMaiores10);
            Console.ReadKey();
            */