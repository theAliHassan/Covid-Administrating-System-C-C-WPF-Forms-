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
    public partial class UserCheck : Form
    {
        public UserCheck()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //3 cases
            //RUN QUERY ON CNIC
            //(i) - NEW USER - make insertion in Regiter Table
            //(i) - 1st SHOT YES - SECOND NO
            NewUser newuser = new NewUser();
            this.Hide();
            newuser.Show();

            //ALREADY VACCINATED
            //AlreadyVaccinated vaccinated = new AlreadyVaccinated();
            //this.Hide();
            //vaccinated.Show();

        }

        private void buttonHOME_Click(object sender, EventArgs e)
        {
            PakistanCovid19_1 newform = new PakistanCovid19_1();
            this.Hide();
            newform.Show();
        }
    }
}
