using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOverflowForms.Data
{
    class UserDAL
    {
        public bool Save(UserDTO user)
        {
            Database database = new Database();

            if (!database.OpenConnection())
                return false;
            
            database.command.CommandText = "INSERT INTO users(name, password) VALUES (@name, 'test')";
            database.command.Parameters.AddWithValue("@name", user.LastName);

            int affectedRows = database.command.ExecuteNonQuery();

            database.CloseConnection();

            if (affectedRows > 0)
                return true;
            return false;
        }

        public List<UserDTO> GetAll()
        {
            // TODO: Fill

            return null;
        }

        public UserDTO GetById(int id)
        {
            // TODO: Fill

            return new UserDTO();
        }

        public List<UserDTO> GetAllByName(string firstName, string lastName, string insertion)
        {
            // TODO: Fill

            return null;
        }
    }
}
