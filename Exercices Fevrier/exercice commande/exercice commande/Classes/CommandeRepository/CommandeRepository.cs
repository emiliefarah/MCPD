using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercice_commande.Classes.Model;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace exercice_commande.Classes.CommandeRepository
{
    internal class CommandeRepository
    {
        static string connectionString = "Server=localhost;Uid=root;Pwd=;Database=commande";

        public static void AjouterUneCommande(Commande t)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"INSERT INTO Commande (Client_Id ,DateCommande,Total) " +
                    $"VALUES (@ClientId,@Date,@Total)";


                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClientId", t.ClientId);
                    command.Parameters.AddWithValue("@Date", t.DateCommande);
                    command.Parameters.AddWithValue("@Total", t.Total);
                    int nbInsertion = command.ExecuteNonQuery();

                    Console.WriteLine("Le Nombre de Commandes passées : " + nbInsertion);


                }

            }
        }



        public static void SupprimerUneCommandeParClientId(int ClientId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"DELETE FROM Commandes WHERE ClientId=@ClientId;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClientId", ClientId);
                    int nbSuppression = command.ExecuteNonQuery();
                    Console.WriteLine("Le nombre de  commande supprimée sont : " + nbSuppression);

                }
            }

        }

        public static List<Commande> AfficherTouteLesCommandesAvecClientId(int ClientId)
            
        {
            List<Commande> commande = new List<Commande>();
           
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Commande WHERE Client_Id=@ClientId;";

                using(MySqlCommand command = new MySqlCommand( query, connection))

                {
                    command.Parameters.AddWithValue("@ClientId", ClientId);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        commande.Add(new Commande(

                            reader.GetInt32("id"),
                            reader.GetInt32("Client_Id"),
                            reader.GetDateTime("DateCommande"),
                            reader.GetInt32("Total")



                            ));
                    }

                }
            }
            return commande;

        }
        public static void CreateCommandeClient()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = """
                   CREATE TABLE IF NOT EXISTS Commande(
                   Id INT AUTO_INCREMENT PRIMARY KEY ,
                   Client_Id int NOT NULL ,
                   DateCommande DateTime,
                   Total decimal ,
                   CONSTRAINT fk_Client_Id FOREIGN KEY 
                   (Client_Id) REFERENCES Client (Id) 
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