using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---Atividade Cebolinha---");
            Console.WriteLine("Digite algo e será exibido com dislalia, igual o Cebolina da Turma da Mônica.");
            Console.WriteLine();
            Console.WriteLine();
            
            
            string troca = Console.ReadLine(); 
            Console.WriteLine(troca.Replace("r","l").Replace("R","L").Replace("RR","LL").Replace("rr","ll"));
            






        }
    }
}
