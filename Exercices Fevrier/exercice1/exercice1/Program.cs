using MySql.Data.MySqlClient;

string connectionString = "Server=localhost;Uid=root;Pwd=;Database=ado";


using (MySqlConnection connection = new MySqlConnection(connectionString))
{

    connection.Open();
    string query = """
        CREATE TABLE  IF NOT EXISTS personne (
        id INT AUTO_INCREMENT PRIMARY KEY ,
        nom VARCHAR(255),
        prenom VARCHAR(255),
        age INT ,
        email VARCHAR (255) UNIQUE
        );
        """;
    using (MySqlCommand command = new MySqlCommand(query,connection)) 
    {
        command.ExecuteNonQuery();  
    }

}

// si lon utilise using plus besoin de la fermer elle se referme automatiquement a la fin de l'accolade 
//connection.Close();
