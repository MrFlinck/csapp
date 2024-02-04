using System; 
using System.Globalization; 
using System.Collections.Generic; 
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace CSAPP
{
    class Program
    {

        static void Main(string[] args)
        {
            Teste x; 
            x = new Teste(); 
            /// obs: por algum motivo que não sei, o terminal integrado funciona mas o externo e interno não funciona...


            Console.Write("Digite o primeiro número: "); 
            x.Num = int.Parse(Console.ReadLine()); 
            Console.Write("Digite o segundo número: "); 
            x.Num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("A soma dos números é: {0} " , x.Soma(x.Num , x.Num2)); 




        }
    }
}