using System;
using BookOverflowForms.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOverflowForms.Logic
{
    class UserContainer
    {
        public bool AddNewUser(string email, string password1, string password2, string zipCode, string firstName, string insertion, string lastName)
        {
            // TODO: Add more validation.
            
            if (password1 != password2)
                return false;

            // TODO: Hash password.

            UserDTO user = new UserDTO();

            user.Email = email;
            user.Password = password1;
            user.ZipCode = zipCode;
            user.FirstName = firstName;
            user.Insertion = insertion;
            user.LastName = lastName;

            return UserDAL.Save(user);
        }

        public List<User> GetAllUsers()
        {
            List<UserDTO> dtoUsers = UserDAL.GetAll();
            List<User> userUsers = new List<User>();

            foreach (UserDTO user in dtoUsers)
            {
                userUsers.Add(new User(user));
            }

            return userUsers;
        }

        public User GetUserById(int id)
        {
            UserDTO userDTO = UserDAL.GetById(id);

            User user = new User(userDTO);

            return user;
        }

        public List<User> GetAllByName(string firstName, string insertion, string lastName)
        {
            List<UserDTO> dtoUsers = UserDAL.GetAllByName(firstName, insertion, lastName);
            List<User> userUsers = new List<User>();

            foreach (UserDTO user in dtoUsers)
            {
                userUsers.Add(new User(user));
            }

            return userUsers;
        }
    }
}
