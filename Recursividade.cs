using System;
namespace Aula25Recursividade
{
    public class Recursividade
    {
        public void GerarFibonacci(int antecessor, int sucessor, int vezes){

            if(vezes >= 0){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(antecessor);
                GerarFibonacci(sucessor, antecessor + sucessor, vezes - 1);
                Console.ResetColor();

            }
        }

        public void GerarTribonacci(int n1, int n2, int n3, int vezes){

            if(vezes >= 0){
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(n1);
                GerarTribonacci(n2, n3, n1 + n2 + n3, vezes - 1 );
                Console.ResetColor();
            }    
        }

        public int GerarFatorial(int numero){

            if(numero == 1){
                return 1;
            }else{
                return numero * GerarFatorial(numero - 1);
            }
            
        }

    }
}