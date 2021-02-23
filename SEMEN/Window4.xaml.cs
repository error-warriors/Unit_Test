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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
            DataTable dt = Select("Select * from [dbo].[MedCards]");
            d_1.ItemsSource = dt.DefaultView;
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window5 on = new Window5();
            on.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            DataTable dt = Select(string.Concat("Select * from [dbo].[MedCards] where age='", t_1.Text, "' and sex = 'False'"));
            d_1.ItemsSource = dt.DefaultView;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            DataTable dt = Select(string.Concat("Select * from [dbo].[MedCards] where Special=N'", t_1.Text, "'"));
            d_1.ItemsSource = dt.DefaultView;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            DataTable dt = Select(string.Concat("Select * from [dbo].[MedCards] where PIB=N'", t_1.Text, "'"));
            d_1.ItemsSource = dt.DefaultView;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            DataTable dt = Select("Select * from [dbo].[MedCards]");
            d_1.ItemsSource = dt.DefaultView;
        }

        private void d_1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
