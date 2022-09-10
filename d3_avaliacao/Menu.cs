

using System.Data;

namespace d3_avaliacao
{
    public class Menu : AcessoBanco
    {
        string email { get; set; }
        string senha { get; set; }
        Menu receptor = new Menu();
        string opcao1 { get; set; }
        string opcao2 { get; set; }
        string option1;
        DateTime dataEntrada = new DateTime();

        public void MenuAcesso()
        {
            do
            {

                Console.WriteLine("Olá, seja bem vindo ao Real Banco Brasil! ");
                Console.WriteLine("Escolha a opção desejada: ");
                Console.WriteLine("Acessar - digite 1 ");
                Console.WriteLine("Cancelar - digite 2 ");

                opcao1 = Console.ReadLine();


                switch (opcao1)
                {
                    case "1":
                        Console.WriteLine("Realize o login digitando seu email e senha previamente registrados: ");
                        break;
                    case "2":
                        Environment.Exit(0);
                        break;
                }


                do
                {
                    Console.WriteLine("E-mail:");
                    email = Console.ReadLine();
                    Console.WriteLine("Senha:");
                    senha = Console.ReadLine();

                    receptor.AcessoLogin(email, senha);



                    if (validacao == true)
                    {
                        Console.WriteLine("Histórico de Conexão desse usuário" + dataEntrada);
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
                        Console.WriteLine("Realize o login digitando seu email e senha previamente registrados: ");
                        break;
                    case "2":
                        Environment.Exit(0);
                        break;
                }
            } while (opcao2 != "1");
    }
    }
}
