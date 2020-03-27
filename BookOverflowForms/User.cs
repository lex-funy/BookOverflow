using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOverflowForms
{
    class User
    {
        public string Name { get; set; }
        private string password;

        public User (string name, string password)
        {
            this.Name = name;
            this.password = password;
        }

        public override string ToString()
        {
            return $"{this.Name}";
        }

        public List<User> GetAllUsers()
        {
            return new List<User>();
        }

        public bool Create()
        {
            string serverName = "localhost";
            string userID = "root";
            string password = "";
            string database = "BookOverflow";

            string connstring = $"server={serverName};userid={userID};password={password};database={database}";
            MySqlConnection conn = new MySqlConnection(connstring);

            conn.Open();

            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO users(name, password) VALUES (@name, @password)";
            comm.Parameters.AddWithValue("@name", this.Name);
            comm.Parameters.AddWithValue("@password", this.password);

            int affectedRows = comm.ExecuteNonQuery();

            conn.Close();

            if (affectedRows > 0)
                return true;
            return false;
        }
    }
}
