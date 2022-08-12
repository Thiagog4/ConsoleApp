using System.Data.SqlClient;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public class Collaborators
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public DateTime dataDeCriacao { get; set; } = DateTime.Now;
    }
    static void Main(string[] args)
    {
        SqlConnection sqlConnection;
        string connectionString = @"Data Source=.;Initial Catalog=Collaborators;Integrated Security=True";
        try
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            Console.WriteLine("Conecxão realizada com sucesso");
            List<Collaborators> colaboradores = new List<Collaborators>();
            
           colaboradores.Add(new Collaborators{Nome="Jonn",dataDeCriacao= DateTime.Now});
           colaboradores.Add(new Collaborators{Nome="Matt",dataDeCriacao= DateTime.Now});
           colaboradores.Add(new Collaborators{Nome="Marcus",dataDeCriacao= DateTime.Now});
           colaboradores.Add(new Collaborators{Nome="Thiago",dataDeCriacao= DateTime.Now});
           colaboradores.Add(new Collaborators{Nome="Elvis",dataDeCriacao= DateTime.Now});
           colaboradores.Add(new Collaborators{Nome="Pedro",dataDeCriacao= DateTime.Now});
           colaboradores.Add(new Collaborators{Nome="Pietro",dataDeCriacao= DateTime.Now});
           colaboradores.Add(new Collaborators{Nome="Wellson",dataDeCriacao= DateTime.Now});
           colaboradores.Add(new Collaborators{Nome="Tony",dataDeCriacao= DateTime.Now});
           colaboradores.Add(new Collaborators{Nome="Bruce",dataDeCriacao= DateTime.Now});
                    
            
            

            Console.WriteLine("Realizando Insert de 10 cadastros!");

            foreach (var colob in colaboradores)
            {
                Console.WriteLine("Nome: " + colob.Nome + " Data de criacão: " + colob.dataDeCriacao);
                string insertQuery = "INSERT INTO COLLABORATOR(Nome,Data_da_Criacao) VALUES('" + colob.Nome + "'," + "'" + colob.dataDeCriacao + "'" + ")";
                SqlCommand insertCommand = new SqlCommand(insertQuery,sqlConnection);
                insertCommand.ExecuteNonQuery();
                

            }


            Console.WriteLine("Inseridos 10 com sucesso!");

        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    
}
