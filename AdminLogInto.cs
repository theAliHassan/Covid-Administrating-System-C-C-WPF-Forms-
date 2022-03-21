using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db
{
    public partial class AdminLogInto : Form
    {
        public AdminLogInto()
        {
            InitializeComponent();
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            string password = textBoxPassword.Text;
        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            //check from database if username and password is correct
            //IF CORRECT - ADMIN MENU
            AdminMENU menu = new AdminMENU();
            this.Hide();
            menu.Show();

            //IF FLASE
            //GO HOME
        }

        private void buttonHOME_Click(object sender, EventArgs e)
        {
            this.Hide();
            PakistanCovid19_1 newobject = new PakistanCovid19_1();
            newobject.Show();
        }

        private void buttonEXIT_Click(object sender, EventArgs e)
        {
            this.Hide();
            PakistanCovid19_1 newobject = new PakistanCovid19_1();
            newobject.Show();
            newobject.Close();
            
        }
    }
}
