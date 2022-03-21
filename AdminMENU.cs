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
    public partial class AdminMENU : Form
    {
        public AdminMENU()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            registeredInfo reginfo = new registeredInfo();
            this.Hide();
            reginfo.Show();
        }

        private void buttoncentres_Click(object sender, EventArgs e)
        {
            VaccinationCenteresInfo info = new VaccinationCenteresInfo();
            this.Hide();
            info.Show();
        }

        private void buttonHOME_Click(object sender, EventArgs e)
        {
            PakistanCovid19_1 newform = new PakistanCovid19_1();
            this.Hide();
            newform.Show();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            AdminInfo admininfo = new AdminInfo();
            this.Hide();
            admininfo.Show();
        }
    }
}
