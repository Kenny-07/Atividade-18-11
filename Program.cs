using System;

namespace Atividade_18_11
{
    class Program
    {
        static void Main(string[] args)
        {

            string login;
            string senha;

            do{
            Console.WriteLine("Digite seu Login: ");
            login = (Console.ReadLine());
            Console.WriteLine("Digite sua Senha ( lembre-se que a senha deve ser diferente do Login ): ");
            senha = (Console.ReadLine());

            if(login == senha ){
                Console.WriteLine("Senha Inválida, tente novamente.");

            }

            } while (login == senha);

            Console.WriteLine("Login concluido!");
        }
    }
}
