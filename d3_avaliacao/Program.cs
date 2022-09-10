using System.Data.SqlClient;

namespace d3_avaliacao
{
    public class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando Aplicação...");
            Menu menu = new Menu();
            menu.MenuAcesso();
        }
    }
}