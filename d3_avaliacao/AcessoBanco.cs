using System.Data.SqlClient;

namespace d3_avaliacao
{
    public class AcessoBanco
    {
       public bool validacao { get; set; }
       private string emailRegistrado {get; set;}
       private string senhaRegistrada { get; set; }
       private string nomeRegistrado { get; set; }
       private string cargoRegistrado {get; set;}
    int IdRegistrado { get; set; }
    public bool AcessoLogin(string email, string senha)
        {
           

            string connectionString = "Server=labsoft.pcs.usp.br;Database=db_8;User Id=usuario_8;Password=50411911821;";

            SqlConnection connection = new SqlConnection(connectionString); 
            connection.Open();
            string loginSql = "SELECT [Nome], [Email], [Senha], [ID], [Cargo] FROM [dbo].[RealBancoBrasil] (nolock)";
            SqlCommand comando = new SqlCommand(loginSql, connection);
            SqlDataReader dataReader = comando.ExecuteReader();

            while (dataReader.Read())
            {
                AcessoBanco chama = new AcessoBanco();
                chama.nomeRegistrado = (string)dataReader["Nome"];
                chama.emailRegistrado = (string)dataReader["Email"];
                chama.senhaRegistrada = (string)dataReader["Senha"];
                chama.cargoRegistrado = (string)dataReader["Cargo"];
                chama.IdRegistrado = (int)dataReader["ID"];
            }

            if (email == emailRegistrado && senha == senhaRegistrada)
            {
                validacao = true;
                Console.WriteLine("Olá, seja bem vindo " + cargoRegistrado +" "+ nomeRegistrado +" "+ IdRegistrado);
            }
            else
            {
                validacao = false;
            }
            connection.Close();
            return validacao;
        }
    }
}
