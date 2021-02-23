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
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\SEMEN-master\SEMEN\DB.mdf; Integrated Security=True");
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = string.Concat("Insert into [dbo].[MedCards] (PIB) Values ('NULL');");
            sqlCommand.ExecuteScalar();
            sqlCommand.CommandText = string.Concat("SELECT top 1 ID FROM [dbo].[MedCards] order by ID Desc;");
            double i = Convert.ToDouble(sqlCommand.ExecuteScalar().ToString());
            if (!String.IsNullOrEmpty(t_1.Text))
            {
                sqlCommand.CommandText = string.Concat("Update [dbo].[MedCards] set PIB = N'", t_1.Text, "' where ID = ", i, ";");
                sqlCommand.ExecuteScalar();
            }
            bool sex = (Convert.ToBoolean(t_2.SelectedIndex));

                sqlCommand.CommandText = string.Concat("Update [dbo].[MedCards] set sex = '", sex, "' where ID = ", i, ";");
                sqlCommand.ExecuteScalar();

            if (!String.IsNullOrEmpty(t_3.Text))
            {
                sqlCommand.CommandText = string.Concat("Update [dbo].[MedCards] set age = '", Convert.ToInt32(t_3.Text), "' where ID = ", i, ";");
                sqlCommand.ExecuteScalar();
            }
            if (!String.IsNullOrEmpty(t_4.Text))
            {
                sqlCommand.CommandText = string.Concat("Update [dbo].[MedCards] set PhoneNumber = N'", t_4.Text, "' where ID = ", i, ";");
                sqlCommand.ExecuteScalar();
            }
            if (!String.IsNullOrEmpty(t_5.Text))
            {
                sqlCommand.CommandText = string.Concat("Update [dbo].[MedCards] set NumWard = '", Convert.ToInt32(t_5.Text), "' where ID = ", i, ";");
                sqlCommand.ExecuteScalar();
            }
            if (!String.IsNullOrEmpty(t_6.Text))
            {
                sqlCommand.CommandText = string.Concat("Update [dbo].[MedCards] set Special = N'", t_6.Text, "' where ID = ", i, ";");
                sqlCommand.ExecuteScalar();
            }
            if (!String.IsNullOrEmpty(t_7.Text))
            {
                sqlCommand.CommandText = string.Concat("Update [dbo].[MedCards] set lastDiagnosis = N'", t_7.Text, "' where ID = ", i, ";");
                sqlCommand.ExecuteScalar();
            }
            if (!String.IsNullOrEmpty(t_8.Text))
            {
                sqlCommand.CommandText = string.Concat("Update [dbo].[MedCards] set Etiology = N'", t_8.Text, "' where ID = ", i, ";");
                sqlCommand.ExecuteScalar();
            }
            sqlCommand.CommandText = string.Concat("Update [dbo].[MedCards] set DateIn=GETDATE() where ID = ", i, ";");
            sqlCommand.ExecuteScalar();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window4 on = new Window4();
            on.Show();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\SEMEN-master\SEMEN\DB.mdf; Integrated Security=True");
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = string.Concat("Delete from [dbo].[MedCards] where id = ", t_10.Text, ";");
            sqlCommand.ExecuteScalar();
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\SEMEN-master\SEMEN\DB.mdf; Integrated Security=True");
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            if (!String.IsNullOrEmpty(t_1.Text))
            {
                sqlCommand.CommandText = string.Concat("Update [dbo].[MedCards] set PIB = '", t_1.Text,"' where ID = ", t_10.Text, ";");
                sqlCommand.ExecuteScalar();
            }
            bool? sex = (Convert.ToBoolean(t_2.SelectedIndex));

                sqlCommand.CommandText = string.Concat("Update [dbo].[MedCards] set sex = '", sex, "' where ID = ", t_10.Text, ";");
                sqlCommand.ExecuteScalar();
            
            if (!String.IsNullOrEmpty(t_3.Text))
            {
                sqlCommand.CommandText = string.Concat("Update [dbo].[MedCards] set age = '", Convert.ToInt32(t_3.Text), "' where ID = ", t_10.Text, ";");
                sqlCommand.ExecuteScalar();
            }
            if (!String.IsNullOrEmpty(t_4.Text))
            {
                sqlCommand.CommandText = string.Concat("Update [dbo].[MedCards] set PhoneNumber = '", t_4.Text, "' where ID = ", t_10.Text, ";");
                sqlCommand.ExecuteScalar();
            }
            if (!String.IsNullOrEmpty(t_5.Text))
            {
                sqlCommand.CommandText = string.Concat("Update [dbo].[MedCards] set NumWard = '", Convert.ToInt32(t_5.Text), "' where ID = ", t_10.Text, ";");
                sqlCommand.ExecuteScalar();
            }
            if (!String.IsNullOrEmpty(t_6.Text))
            {
                sqlCommand.CommandText = string.Concat("Update [dbo].[MedCards] set Special = '", t_6.Text, "' where ID = ", t_10.Text, ";");
                sqlCommand.ExecuteScalar();
            }
            if (!String.IsNullOrEmpty(t_7.Text))
            {
                sqlCommand.CommandText = string.Concat("Update [dbo].[MedCards] set lastDiagnosis = '", t_7.Text, "' where ID = ", t_10.Text, ";");
                sqlCommand.ExecuteScalar();
            }
            if (!String.IsNullOrEmpty(t_8.Text))
            {
                sqlCommand.CommandText = string.Concat("Update [dbo].[MedCards] set Etiology = '", t_8.Text, "' where ID = ", t_10.Text, ";");
                sqlCommand.ExecuteScalar();
            }

        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\SEMEN-master\SEMEN\DB.mdf; Integrated Security=True");
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = string.Concat("SELECT PIB FROM [dbo].[MedCards] WHERE id = ", t_10.Text);
            string t_PIB = sqlCommand.ExecuteScalar().ToString();
            sqlCommand.CommandText = string.Concat("SELECT sex FROM [dbo].[MedCards] WHERE id = ", t_10.Text);
            bool? t_sex = Convert.ToBoolean(sqlCommand.ExecuteScalar().ToString());
            sqlCommand.CommandText = string.Concat("SELECT age FROM [dbo].[MedCards] WHERE id = ", t_10.Text);
            int t_age = Convert.ToInt32(sqlCommand.ExecuteScalar().ToString());
            sqlCommand.CommandText = string.Concat("SELECT PhoneNumber FROM [dbo].[MedCards] WHERE id = ", t_10.Text);
            string t_PhoneNumber = sqlCommand.ExecuteScalar().ToString();
            sqlCommand.CommandText = string.Concat("SELECT lastDiagnosis FROM [dbo].[MedCards] WHERE id = ", t_10.Text);
            string t_lastDiagnosis = sqlCommand.ExecuteScalar().ToString();
            sqlCommand.CommandText = string.Concat("SELECT Etiology FROM [dbo].[MedCards] WHERE id = ", t_10.Text);
            string t_Etiology = sqlCommand.ExecuteScalar().ToString();
            sqlCommand.CommandText = string.Concat("SELECT Special FROM [dbo].[MedCards] WHERE id = ", t_10.Text);
            string t_Special = sqlCommand.ExecuteScalar().ToString();
            sqlCommand.CommandText = string.Concat("SELECT DateIn FROM [dbo].[MedCards] WHERE id = ", t_10.Text);
            DateTime t_DateIn = Convert.ToDateTime(sqlCommand.ExecuteScalar().ToString());
            string t_resOut = t_11.Text;

            sqlCommand.CommandText = string.Concat("INSERT [dbo].[PatientsOut] (PIB, sex, age, PhoneNumber, lastDiagnosis, Etiology, Special, resOut, DateOut) VALUES(N'", t_PIB,"','", t_sex, "','", t_age, "','", t_PhoneNumber, "',N'", t_lastDiagnosis, "',N'", t_Etiology, "',N'", t_Special, "',N'", t_resOut, "', GETDATE());");
            sqlCommand.ExecuteScalar();
            sqlCommand.CommandText = string.Concat("Delete from [dbo].[MedCards] where id = ", t_10.Text, ";");
            sqlCommand.ExecuteScalar();
        }
    }
}
