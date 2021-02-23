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
using System.Windows.Shapes;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SEMEN
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            DataTable dt = Select("Select * from [dbo].[PatientsOut]");
            resout.ItemsSource = dt.DefaultView;
        }
        
        public DataTable Select(string selectSQL)
        {
            DataTable dataTable = new DataTable("dataBase");

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\SEMEN-master\SEMEN\DB.mdf; Integrated Security=True");
            sqlConnection.Open();                            
            SqlCommand sqlCommand = sqlConnection.CreateCommand();       
            sqlCommand.CommandText = selectSQL;                          
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;   
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow on = new MainWindow();
            on.Show();
        }

        private void Cumming_Click(object sender, RoutedEventArgs e)
        {
            Cum.Content = Select("Select * from [dbo].[PatientsOut]").Rows.Count;
        }
    }
}
