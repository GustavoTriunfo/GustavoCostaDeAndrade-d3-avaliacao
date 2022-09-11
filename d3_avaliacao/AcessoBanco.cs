using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;

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
               
                nomeRegistrado = (string)dataReader["Nome"];
                emailRegistrado = (string)dataReader["Email"];
                senhaRegistrada = (string)dataReader["Senha"];
                cargoRegistrado = (string)dataReader["Cargo"];
                IdRegistrado = (int)dataReader["ID"];
            }

            if (email == emailRegistrado && senha == senhaRegistrada)
            {
                validacao = true;
                Console.WriteLine("Olá, seja bem vindo " + cargoRegistrado +" "+ nomeRegistrado +" "+ IdRegistrado);
                RegistrarAcessoUsing();
            }
            else
            {
                validacao = false;
            }
            connection.Close();
            return validacao;
        }

        //private void RegistrarAcesso()
        //{

        //    string path = Path.Combine(Directory.GetCurrentDirectory(), "output.txt");
        //    FileStream f = new FileStream(path, FileMode.Append);
        //    StreamWriter s = new StreamWriter(f);

        //    s.WriteLine("O usuário " + nomeRegistrado + "(" + IdRegistrado + ") " + "acessou o sistema em " + DateTime.Now);
        //    s.Close();
        //    f.Close();
        //}


        private void RegistrarAcessoUsing()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "output.txt");
            using (FileStream f = new FileStream(path, FileMode.Append))
            {
                using (StreamWriter s = new StreamWriter(f)) 
                {

                    s.WriteLine("O usuário " + nomeRegistrado + "(" + IdRegistrado + ") " + "acessou o sistema em " + DateTime.Now);
                };
            };
        }
    }
}
