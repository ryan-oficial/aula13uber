using System;

namespace Aula13Uber
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario user = new Usuario();


            System.Console.WriteLine("Digite seu login: ");
            string login = Console.ReadLine();

            System.Console.WriteLine("Digite sua senha");
            string senha = Console.ReadLine();


            user.Login(login, senha);

            if(user.TokenLogin != "" && user.TokenLogin != null){
                System.Console.WriteLine("Acesso liberado, seja bem vindo");
                System.Console.WriteLine("Chamar uber? \n 1-Sim \n 2-Não ");
                int resposta = Int32.Parse( Console.ReadLine() );

                switch(resposta)
                {
                    case 1:
                    System.Console.WriteLine("Procurando uber . . . ");
                    System.Console.WriteLine("Voce achou um uber ele ja esta a caminho ");
                    System.Console.WriteLine("Fazendo corrida . . . ");
                    System.Console.WriteLine("Corrida terminada, obrigado por usar nossos serviços");
                    break;

                    case 2:
                    System.Console.WriteLine("Obrigado por usar nosso sistema");
                    break;
                    
                }
                
            }else
            {
                System.Console.WriteLine("Login e senha invalidos, tente novamente ");
            }

            

            
            
              }
        }
    
}
