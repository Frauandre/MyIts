using System;
using System.Data.SqlClient;

namespace ConnessioneDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Connessione al database MS SQL Server");

            //creo la stringa di connessione
            SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
            connection.DataSource = "localhost";
            connection.UserID = "sa";
            connection.Password = "Its-2022";
            connection.InitialCatalog = "Anagrafica"; //nome del Database

            //connessione al database
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connection.ConnectionString;
            sqlConnection.Open();
            Console.WriteLine("Connessione al Database riuscita!");

            //accesso ai dati
            string sql = "Select * from Studenti";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = sql;
            sqlCommand.CommandType = System.Data.CommandType.Text;

            SqlDataReader sdr = sqlCommand.ExecuteReader();

            string msg = "";
            while (sdr.Read())
            {
                msg += "matricola: " + sdr.GetInt32("Matricola");
                msg += "nome: " + sdr.GetString("Nome");
                msg += "cognome: " + sdr.GetString("Cognome");
                msg += "email: " + sdr.GetString("Email");
                msg += "classe: " + sdr.GetString("Classe");
                msg += "\n";
            }
            Console.WriteLine(msg);

            sdr.Close();
            sqlCommand.Clone();

            //chiudere la connessione
            sqlConnection.Close();

        }
    }
}
