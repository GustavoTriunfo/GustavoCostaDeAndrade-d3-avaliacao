

using System.Data;

namespace d3_avaliacao
{
    public class Menu
    {
        string email { get; set; }
        string senha { get; set; }
           
         string opcao1 { get; set; }
        string opcao2 { get; set; }
        string option1;
        

        public void MenuAcesso()
        {
            do
            {

                Console.WriteLine("Olá, seja bem vindo ao Real Banco Brasil! ");
                Console.WriteLine("Escolha a opção desejada: ");
                Console.WriteLine("Acessar - digite 1 ");
                Console.WriteLine("Cancelar - digite 2 ");


                do {

                    opcao1 = Console.ReadLine();

                    switch (opcao1)
                    {
                        case "1":
                            Console.WriteLine("Realize o login digitando seu email e senha previamente registrados: ");
                            break;
                        case "2":
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Entrada Incorreta! Por favor digite 1 para realizar o login ou 2 para cancelar a operação");
                            break;
                    }
                } while (opcao1 != "1" && opcao1 != "2");

                bool validacao = false;
                do
                {
                    Console.WriteLine("E-mail:");
                    email = Console.ReadLine();
                    Console.WriteLine("Senha:");
                    
                    senha = Console.ReadLine();

                    AcessoBanco acessoBanco = new AcessoBanco();

                    validacao =  acessoBanco.AcessoLogin(email, senha);

                    if (validacao == true)
                    {
                        Console.WriteLine("O que deseja fazer?");
                    }
                    else
                    {
                        Console.WriteLine("O Login está incorreto! Verifique se digitou o e-mail/senha corretamente.");
                    }
                } while (validacao == false);

                Console.WriteLine("Deslogar - digite 1 ");
                Console.WriteLine("Encerrar Sistema - digite 2 ");

                opcao2 = Console.ReadLine();

                switch (opcao2)
                {
                    case "1":
                        Console.WriteLine("Usuário deslogado.");
                        break;
                    case "2":
                        Environment.Exit(0);
                        break;
                }
            } while (opcao2 == "1");
    }
    }
}
