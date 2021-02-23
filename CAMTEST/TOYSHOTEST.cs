using Microsoft.VisualStudio.TestTools.UnitTesting;
using SEMEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

using System.Windows.Input;

namespace CAMTEST
{
    [TestClass]
    public class TOYSHOTEST
    {
        [TestMethod]
        public void Cumetod(string selectSQL)
        {
            DataTable dataTable = new DataTable("dataBase");
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\SEMEN-master\SEMEN\DB.mdf; Integrated Security=True");
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = selectSQL;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            int Content = dataTable.Rows.Count;

            sqlCommand.CommandText = string.Concat("Insert into [dbo].[MedCards] (PIB) Values ('NULL');");
            sqlCommand.ExecuteScalar();

            sqlCommand.CommandText = string.Concat("SELECT top 1 ID FROM [dbo].[MedCards] order by ID Desc;");
            double i = Convert.ToDouble(sqlCommand.ExecuteScalar().ToString());

            sqlCommand.CommandText = selectSQL;
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            int Cocktent = dataTable.Rows.Count;

            sqlCommand.CommandText = string.Concat("Delete from [dbo].[MedCards] where id = ", i, ";");
            sqlCommand.ExecuteScalar();

            Assert.AreEqual(Content+1, Cocktent, "true");
        }
    }
}
