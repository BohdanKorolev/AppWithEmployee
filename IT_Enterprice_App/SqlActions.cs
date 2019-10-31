using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace IT_Enterprice_App
{
    class SqlActions
    {
        static public void SqlConfigCreater(string stringName)
        {
            SqlConnectionStringBuilder sqlConnectionString = new SqlConnectionStringBuilder();
            sqlConnectionString.DataSource = @".\SQLEXPRESS";
            sqlConnectionString.InitialCatalog = "IT_Enterprice";
            sqlConnectionString.IntegratedSecurity = true;

            var setting = new ConnectionStringSettings
            {
                Name = stringName,
                ConnectionString = sqlConnectionString.ConnectionString
            };

            Configuration configuration;
            configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.ConnectionStrings.ConnectionStrings.Add(setting);
            configuration.Save();
        }
        public static void SqlRefreshDataTable(DataGridView Data_Display, string query)
        {
            int rowNumber = 0, colNumber = 0;
            Data_Display.Rows.Clear();
            Data_Display.Columns.Clear();
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = query;
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    Data_Display.Columns.Add(dataReader.GetName(i), dataReader.GetName(i));
                }
                while (dataReader.Read())
                {
                    Data_Display.Rows.Add();
                    for (colNumber = 0; colNumber < dataReader.FieldCount; colNumber++)
                    {
                        Data_Display.Rows[rowNumber].Cells[colNumber].Value = dataReader[colNumber];
                    }
                    rowNumber++;
                }
            }
        }
        static public void AdapterFilling(string command, DataGridView dataDisplay)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command, connectionString);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataDisplay.DataSource = dataSet.Tables[0];
        }
    }
}
