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
    public partial class VaccinationCenteresInfo : Form
    {
        //
        private string name, made, required, available, vaccineID;
        public VaccinationCenteresInfo()
        {
            InitializeComponent();
            label1.Hide();
            textBox1.Hide();
            dataGridView1.Hide();
            button3.Hide();
            button4.Hide();
            labelavailable.Hide();
            labelMade.Hide();
            labelNAME.Hide();
            labelrequired.Hide();

            textBoxAvailable.Hide();
            textBoxMade.Hide();
            textBoxRequired.Hide();
            textBoxName.Hide();
            buttonUpdate.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            label1.Show();
            textBox1.Show();
            button3.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            label1.Show();
            textBox1.Show();
            button4.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //THESE VARIABLES WILL HAVE USER NEW UPDATED VALUES - UPDATE IN VACCINE TABLE USING THESE VARIABLES;
            this.name = textBoxName.Text;
            this.made = textBoxMade.Text;
            this.available = textBoxAvailable.Text;
            this.required = textBoxRequired.Text;
            VaccinationCenteresInfo newform = new VaccinationCenteresInfo();
            this.Close();
            newform.Show();

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            AdminMENU menu = new AdminMENU();
            this.Close();
            menu.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonHOME_Click(object sender, EventArgs e)
        {
            PakistanCovid19_1 newform = new PakistanCovid19_1();
            this.Close();
            newform.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            label1.Hide();
            textBox1.Hide();
            dataGridView1.Show();
            //RUN QUERY ON THIS ENTERED ID AND SHOW QUERY TABLE IN DATA GRID VIEW;
            vaccineID=textBox1.Text;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //UPDATE 
            button1.Hide();
            button2.Hide();
            button4.Hide();
            label1.Hide();
            textBox1.Hide();
            labelavailable.Show();
            labelMade.Show();
            labelNAME.Show();
            labelrequired.Show();
            textBoxAvailable.Show();
            textBoxMade.Show();
            textBoxRequired.Show();
            textBoxRequired.Show();
            textBoxName.Show();
            buttonUpdate.Show();

        }
    }
}
