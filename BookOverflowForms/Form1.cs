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
            InitializeComponent();

            Database database = new Database();
            this.users = database.GetAllUsers();

            foreach (User user in this.users)
            {
                lbUsers.Items.Add(user);
            }
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

                    Database database = new Database();
                    if (database.AddUser(user))
                        MessageBox.Show("SUCCESS: Users added to database");
                    else 
                        MessageBox.Show("ERROR: User could not be added to database");

                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtConfirmPassword.Text = "";

                    this.UpdateListBox();
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            User user = (User)lbUsers.SelectedItem;

            Database database = new Database();

            if (database.RemoveUser(user.Id))
            {

                MessageBox.Show("SUCCESS: User removed");
                users.Remove(user);
            }
            else
            {
                MessageBox.Show("ERROR: User not removed");
            }

            this.UpdateListBox();
        }

        private void UpdateListBox()
        {
            lbUsers.Items.Clear();

            foreach (User user in users)
            {
                lbUsers.Items.Add(user);
            }
        }
    }
}
