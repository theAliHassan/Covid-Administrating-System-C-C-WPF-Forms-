using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using Oracle.DataAccess.Types;
using System.Configuration;
using Oracle.DataAccess.Client;


namespace db
{  public partial class MainWindow : Window
    {
        OracleConnection con = null;
        public MainWindow()
        {
            this.setconnection();
            InitializeComponent();
            Form2 newform = new Form2();
            this.Hide();
            newform.Show();
        }
        public void setconnection(){
            string connectionString = ConfigurationManager.ConnectionStrings["myconnectionstring"].ConnectionString;
            con = new OracleConnection(connectionString);
            try
            {
                con.Open();
            }
            catch (Exception exp)
            {

            }
        }
        private void update_data_grid() 
        {
            con.Open();
           
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void Grid_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {

        }
        private void Grid_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        
    }
}
