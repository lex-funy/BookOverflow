using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOverflowForms.Data
{
    class Database
    {
        private string server;
        private string username;
        private string password;
        private string database;

        private MySqlConnection connection;
        public MySqlCommand command;

        public Database()
        {
            // FIXME: Put in config.
            this.server   = "localhost";
            this.username = "root";
            this.password = "";
            this.database = "bookoverflow";
        }

        public bool OpenConnection()
        {
            string connectionString = $"server={this.server};userid={this.username};password={this.password};database={this.database}";

            this.connection = new MySqlConnection(connectionString);

            try
            {
                this.connection.Open();

                this.command = this.connection.CreateCommand();

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public void CloseConnection()
        {
            this.connection.Close();
        }

        public List<User> GetAllUsers()
        {
            this.OpenConnection();

            MySqlCommand command = this.connection.CreateCommand();

            command.CommandText = "SELECT ID, name FROM users WHERE deleted_at IS NULL";

            MySqlDataReader result = command.ExecuteReader();

            List<User> users = new List<User>();
            while (result.Read())
            {
                int id = result.GetInt16(0);
                string name = result.GetString(1);

                users.Add(new User(id, name));
            }

            return users;
        }

        public User GetUserByID(int id)
        {
            this.OpenConnection();

            MySqlCommand command = new MySqlCommand();
            
            command.CommandText = "SELECT name FROM users WHERE id = @id";
            
            command.Parameters.AddWithValue("@id", "id");

            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();

            string name = reader.GetString(0);

            return new User(id, name);
        }

        public bool RemoveUser(int id)
        {
            this.OpenConnection();

            MySqlCommand command = this.connection.CreateCommand();

            command.CommandText = "UPDATE users SET deleted_at = @deleted_at WHERE id = @id";

            command.Parameters.AddWithValue("@deleted_at", DateTime.Now);
            command.Parameters.AddWithValue("@id", id);

            int affectedRows = command.ExecuteNonQuery();

            if (affectedRows > 0)
                return true;
            return false;
        }
    }
}
