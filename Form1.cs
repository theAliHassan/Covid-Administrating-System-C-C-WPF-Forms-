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
    //Main Start
    public partial class PakistanCovid19_1 : Form
    {
        public PakistanCovid19_1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            AdminLogInto newform = new AdminLogInto();
            this.Hide();
            newform.Show();
        }
        private void buttonUser_Click(object sender, EventArgs e)
        {
            UserCheck newform = new UserCheck();
            this.Hide();
            newform.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxGovt_Click(object sender, EventArgs e)
        {

        }
    }
}
