using System;
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
    public partial class Form1 : Form
    {
        private List<User> users;

        public Form1()
        {
            this.users = new List<User>();

            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (name != "" && password != "" && confirmPassword != "")
            {
                if (password == confirmPassword)
                {
                    User user = new User(name, password);
                    users.Add(user);

                    MessageBox.Show("SUCCESS: Users added to list");

                    lbUsers.Items.Add(user);
                    if (user.Create())
                        MessageBox.Show("SUCCESS: Users added to database");
                    else 
                        MessageBox.Show("ERROR: User could not be added to database");

                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtConfirmPassword.Text = "";
                } 
                else
                {
                    MessageBox.Show("ERROR: Passwords don't match.");
                }
            } 
            else
            {
                MessageBox.Show("ERROR: Not all fields are filled in.");
            }
        }
    }
}
