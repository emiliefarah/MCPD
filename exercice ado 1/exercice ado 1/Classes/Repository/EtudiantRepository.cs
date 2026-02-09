using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercice_ado_1.Classes.Model;

using MySql.Data.MySqlClient;

namespace exercice_ado_1.Classes.Repository
{
    internal class EtudiantRepository
    {
       static string connectionString = "Server=localhost;Uid=root;Pwd=;Database=etudiant";

        public static void AjouterUnEtudiant(Etudiant e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();

                string query = $"INSERT INTO Etudiant (nom,prenom,datedenaissance,email)" +
                    $"VALUES (@nom,@prenom,@datedenaissance,@email)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@nom", e.Nom);
                    command.Parameters.AddWithValue("@prenom", e.Prenom);
                    command.Parameters.AddWithValue("@datedenaissance", e.Datedenaissance);
                    command.Parameters.AddWithValue("@email", e.Email);

                    int nbInsertion = command.ExecuteNonQuery();
                    Console.WriteLine("Element(s) ayant été inséré :" + nbInsertion);
                }

            }

        }


        public static void ModifierUnEtudiant(Etudiant e)
        {
            using MySqlConnection connection = new MySqlConnection(connectionString);
            {
                connection.Open();

                string query = $"UPDATE Etudiant SET nom=@nom,prenom=@prenom,datedenaissance=@datedenaissance,email=@email WHERE id = @id";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", e.Id);
                    command.Parameters.AddWithValue("@nom", e.Nom);
                    command.Parameters.AddWithValue("@prenom", e.Prenom);
                    command.Parameters.AddWithValue("@datedenaissance", e.Datedenaissance);
                    command.Parameters.AddWithValue("@email", e.Email);

                    int nbModification = command.ExecuteNonQuery();
                    Console.WriteLine("Etudiant(s) ayant été modifié :" + nbModification);

                }

            }

        }

        public static void SupprimerUnEtudiant(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))

            {
                connection.Open();
                string query = $"DELETE FROM Etudiant WHERE id =@id; ";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    int nbSuppression = command.ExecuteNonQuery();
                    Console.WriteLine("Etudiant(s) ayant été supprimé : " + nbSuppression);
                }


            }

        }


        public static List<Etudiant> AfficherToutLesEtudiants()
        {
            List<Etudiant> etudiants = new List<Etudiant>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();
                string query = "SELECT * FROM Etudiant;";

                using (MySqlCommand command = new MySqlCommand(query, connection))

                {
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())

                    {
                        etudiants.Add(new Etudiant(

                            reader.GetInt32("id"),
                            reader.GetString("nom"),
                            reader.GetString("prenom"),
                            reader.GetDateTime("datedenaissance"),
                            reader.GetString("email")
                            ));

                    }


                }

            }
            return etudiants;

        }

        public static  List<Etudiant> AfficherUnEtudiantParSonNomPrenom(string saisie)
        {
            List<Etudiant> etudiants = new List<Etudiant>();

            using (MySqlConnection conncetion = new MySqlConnection(connectionString))
            {
                conncetion.Open();
                string query = "SELECT * FROM Etudiant WHERE prenom=@prenom OR nom=@nom;";

                using (MySqlCommand command = new MySqlCommand(query, conncetion))

                {
                    command.Parameters.AddWithValue("@nom", saisie);
                    command.Parameters.AddWithValue("@prenom", saisie);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        etudiants.Add(new Etudiant(
                            reader.GetInt32("id"),
                            reader.GetString("nom"),
                            reader.GetString("prenom"),
                            reader.GetDateTime("datedenaissance"),
                            reader.GetString("email")
                            ));
                    }
                }



            }
            return etudiants;

        }

        public static void CreateTableEtudiant()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();


                string query = """
                    CREATE TABLE IF NOT EXISTS Etudiant(
                    id INT AUTO_INCREMENT PRIMARY KEY ,
                    nom VARCHAR (250),
                    prenom VARCHAR(250),
                    datedenaissance DATETIME ,
                    email VARCHAR(250)
                    );
                    
                    TRUNCATE Etudiant;
                    """;

                using (MySqlCommand command = new MySqlCommand(query, connection))

                {
                    command.ExecuteNonQuery();



                }

            }

        }


    }
}


