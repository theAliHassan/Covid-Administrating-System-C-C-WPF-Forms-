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
    public partial class registeredInfo : Form
    {
        private string userID, shot1, shot2, date1, date2;
        public registeredInfo()
        {
            InitializeComponent();
            labelUSERID.Hide();
            textBoxpassword.Hide();
            lableShot1.Hide();
            lableShot2.Hide();
            lableDate1.Hide();
            lableDate2.Hide();

            textBox1Shot.Hide();
            textBox2Shot.Hide();
            textBoxDate1.Hide();
            textBoxDate2.Hide();
            buttonUpdate.Hide();
            button3.Hide();
            button4.Hide();

            dataGridView1.Hide();
        }

        private void labelrequired_Click(object sender, EventArgs e)
        {

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
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.shot1 = textBox1Shot.Text;
            this.shot2 = textBox2Shot.Text;
            this.date1 = textBoxDate1.Text;
            this.date2 = textBoxDate2.Text;

            registeredInfo newform = new registeredInfo();
            this.Close();
            newform.Show();
        }
        private void textBoxpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelUSERID_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonmyUpdate_Click(object sender, EventArgs e)
        {
            labelUSERID.Show();
            textBoxpassword.Show();
            button4.Show();
            buttonmyUpdate.Hide();
            buttonmyView.Hide();
        }
        private void buttonmyView_Click(object sender, EventArgs e)
        {
            buttonmyUpdate.Hide();
            labelUSERID.Show();
            textBoxpassword.Show();
            button3.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            button4.Hide();
            this.userID = textBoxpassword.Text;
            labelUSERID.Hide();
            textBoxpassword.Hide();
            lableShot1.Show();
            lableShot2.Show();
            lableDate1.Show();
            lableDate2.Show();

            textBox1Shot.Show();
            textBox2Shot.Show();
            textBoxDate1.Show();
            textBoxDate2.Show();
            buttonUpdate.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button3.Hide();
            this.userID = textBoxpassword.Text;
            labelUSERID.Hide();
            textBoxpassword.Hide();
            dataGridView1.Show();
        }
    }
}
