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
    public partial class AdminInfo : Form
    {
        private string adminID;
        public AdminInfo()
        {
            InitializeComponent();
            labelAdminID.Hide();
            textBoxpassword.Hide();
            button3.Hide();
            dataGridView1.Hide();
        }
        private void buttonView_Click(object sender, EventArgs e)
        {
            buttonView.Hide();
            labelAdminID.Show();
            textBoxpassword.Show();
            button3.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.adminID = textBoxpassword.Text;
            textBoxpassword.Hide();
            labelAdminID.Hide();
            dataGridView1.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            AdminMENU menu = new AdminMENU();
            this.Close();
            menu.Show();
        }

        private void buttonHOME_Click(object sender, EventArgs e)
        {
            PakistanCovid19_1 newform = new PakistanCovid19_1();
            this.Close();
            newform.Show();
        }
    }
}
