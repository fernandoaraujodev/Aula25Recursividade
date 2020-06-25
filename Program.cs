using System;

namespace Aula25Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursividade calculo = new Recursividade();
            calculo.GerarTribonacci(0,1,2,10);//Azul
            calculo.GerarFibonacci(0,1,15);//Verde
            System.Console.WriteLine(calculo.GerarFatorial(5));//Branco
            
        }
    }
}
