using System;
using BookOverflowForms.Logic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookOverflowForms
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            UserContainer uc = new UserContainer();
            List<User> users = uc.GetAllUsers();

            string output = "";
            foreach (User user in users)
            {
                output += $"{user.ToString()}\n";
            }

            MessageBox.Show(output);
        }

        private void btnById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbId.Text);

            UserContainer uc = new UserContainer();
            User user = uc.GetUserById(id);

            MessageBox.Show(user.ToString());
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            string firstName = tbFirstName.Text;
            string insertion = tbInsertion.Text;
            string lastName = tbLastName.Text;

            UserContainer uc = new UserContainer();
            List<User> users = uc.GetAllByName(firstName, insertion, lastName);

            string output = "";
            foreach (User user in users)
            {
                output += $"{user.ToString()}\n";
            }

            MessageBox.Show(output);
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string password1 = tbPassword1.Text;
            string password2 = tbPassword2.Text;
            string zipCode = tbZipCode.Text;
            string firstName = tbFirstName1.Text;
            string insertion = tbInsertion1.Text;
            string lastName = tbLastName1.Text;

            UserContainer uc = new UserContainer();
            if (uc.AddNewUser(email, password1, password2, zipCode, firstName, insertion, lastName))
                MessageBox.Show("User added succesfully");
            else
                MessageBox.Show("User couldn't be added");
        }
    }
}
