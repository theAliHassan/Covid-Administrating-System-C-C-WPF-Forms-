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
    public partial class AlreadyVaccinated : Form
    {
        public AlreadyVaccinated()
        {
            InitializeComponent();
        }

        private void buttonHOME_Click(object sender, EventArgs e)
        {
            PakistanCovid19_1 newform = new PakistanCovid19_1();
            this.Hide();
            newform.Show();
        }
    }
}
