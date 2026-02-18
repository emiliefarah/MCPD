using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercice_commande.Classes.Model;
using MySql.Data.MySqlClient;

namespace exercice_commande.Classes.CommandeRepository
{
    internal class ClientRepository
    {
        static string connectionString = "Server=localhost;Uid=root;Pwd=;Database=commande";
        public static void AjouterUnClient(Client c)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"INSERT INTO CLIENT (Nom,Prenom,Adresse,CodePostal,Ville,Telephone)" +
                    $"VALUES (@Nom,@Prenom,@Adresse,@CodePostal,@Ville,@Telephone)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nom", c.Nom);
                    command.Parameters.AddWithValue("@Prenom", c.Prenom);
                    command.Parameters.AddWithValue("@Adresse", c.Adresse);
                    command.Parameters.AddWithValue("@CodePostal", c.CodePostal);
                    command.Parameters.AddWithValue("@Ville", c.Ville);
                    command.Parameters.AddWithValue("@Telephone", c.NumeroDeTelephone);
                    int nbInsertion = command.ExecuteNonQuery();
                    Console.WriteLine("Le Nombre de clients est de  : " + nbInsertion);
                }

            }
        }
        public static void ModifierClient(Client c)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = $"UPDATE Client SET nom=@nom,prenom=@prenom,adresse=@adresse,codepostal=@codepostal,ville=@ville,numerodetelephone=@numerodetelephone WHERE id=@id;";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", c.Id);
                    command.Parameters.AddWithValue("@Nom", c.Nom);
                    command.Parameters.AddWithValue("@Prenom", c.Prenom);
                    command.Parameters.AddWithValue("@Adresse", c.Adresse);
                    command.Parameters.AddWithValue("@CodePostal", c.CodePostal);
                    command.Parameters.AddWithValue("@Ville", c.Ville);
                    command.Parameters.AddWithValue("@Telephone", c.NumeroDeTelephone);
                    int nbInsertion = command.ExecuteNonQuery();
                    Console.WriteLine("Le Nombre de clients qui ont ete modifiés : " + nbInsertion);



                }
            }
        }


        public static Client RecupererUnClient(int id)
        {
            Client client;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open ();
                string query = "SELECT * FROM Client WHERE id=@id;";

                    using (MySqlCommand command = new MySqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue ("@id", id);
                    MySqlDataReader reader = command.ExecuteReader();

                    reader.Read();


                    client = new Client(
                        reader.GetInt32("id"),
                        reader.GetString("nom"),
                        reader.GetString("prenom"),
                        reader.GetString("adresse"),
                        reader.GetString("codepostal"),
                        reader.GetString("ville"),
                        reader.GetString("telephone")
                        );
                }
            }return client;




        }

        public static List<Client> AfficherToutLesClients()
        {
            List<Client> Clients = new List<Client>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Client;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Clients.Add(new Client(
                            reader.GetInt32("id"),
                            reader.GetString("nom"),
                            reader.GetString("prenom"),
                            reader.GetString("adresse"),
                            reader.GetString("codepostal"),
                            reader.GetString("ville"),
                            reader.GetString("telephone")

                         ));
                    }
                }
            }
            return Clients;


        }

        public static void SupprimerUnClient(int ClientId)
        {
            CommandeRepository.SupprimerUneCommandeParClientId(ClientId);

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"DELETE FROM Client WHERE ClientId=@ClientId;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClientId", ClientId);
                    int nbSuppression = command.ExecuteNonQuery();
                    Console.WriteLine("Le nombre de Clients supprimée sont : " + nbSuppression);

                }
            }

        }

        public static void CreateTableClient()
        {
            using MySqlConnection connection = new MySqlConnection(connectionString);
            {
                connection.Open();

                string query = """
               DROP TABLE IF EXISTS Commande;
               DROP TABLE IF EXISTS Client;

               CREATE TABLE IF NOT EXISTS Client(
               id INT AUTO_INCREMENT PRIMARY KEY ,
               nom VARCHAR(250),
               prenom VARCHAR(250),
               adresse VARCHAR(250),
               codepostal VARCHAR(250),
               ville VARCHAR(250),
               telephone VARCHAR(250)
               );
               """;
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}