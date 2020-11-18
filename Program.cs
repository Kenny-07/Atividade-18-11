using System;

namespace Atividade_18_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota;

            do{
            Console.WriteLine("Digite um número de 0 a 10 para ganhar um Pc Gamer, boa sorte!");
            nota = int.Parse(Console.ReadLine());

            if(nota <0 || nota >10){
                Console.WriteLine("Nota inválida, digite um valor entre 0 a 10.");
                nota = int.Parse(Console.ReadLine());
            }

            } while (nota <0 || nota >10);

            Console.WriteLine("Retire seu Pc gamer na Casas Bahia mais próxima de sua residencia!");
        }
    }
}
