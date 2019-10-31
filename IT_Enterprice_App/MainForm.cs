using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IT_Enterprice_App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SqlActions.ConfigCreater("ConnectionString");

            GroupByChekList.CheckOnClick = true;
            SqlActions.SqlRefreshDataTable(Data_Display, "SELECT * FROM [All_Info]");
        }

        private void GroupByButton_Click(object sender, EventArgs e)
        {
            //========================================================================================================================================================
            //========================================================================================================================================================

            string query = "SELECT ";
            int comma = 1;
            foreach (var item in GroupByChekList.CheckedItems)
            {
                query += "[" + item + "], ";
            }
            query += "SUM([Count]) AS [Count], SUM([Amount]) AS [Amount] FROM [All_Info] GROUP BY ";
            
           foreach (var item in GroupByChekList.CheckedItems)
            {
                query += "[" + item + "] ";
                if (comma != GroupByChekList.CheckedItems.Count)
                {
                    query += ", ";
                    comma++;
                }
            }
            query += ";";

            //========================================================================================================================================================
            //========================================================================================================================================================

            //MessageBox.Show(query);
            try
            {
                SqlActions.SqlRefreshDataTable(Data_Display, query);
            }
            catch (Exception)
            {
                SqlActions.SqlRefreshDataTable(Data_Display, "SELECT * FROM [All_Info]");
            }
        }
    }
}
