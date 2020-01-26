using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data.Odbc;

namespace HH_Csharp_ReadDB001
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;
        OdbcConnection odbcConnection;
        const string odbcConnectionString = "DSN=maria_simple_db"; // dsnname has been changed
        public Form1()
        {
            InitializeComponent(); 
        } 

        private void Form1_Load(object sender, EventArgs e)
        {
            this.odbcConnection = new OdbcConnection(odbcConnectionString);
            this.odbcConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string readQuery = "SELECT * from simple_table";
            OdbcCommand odbcCommand = new OdbcCommand(readQuery);
            odbcCommand.Connection = this.odbcConnection;
            OdbcDataReader odbcDataReader = odbcCommand.ExecuteReader();

          
            if (odbcDataReader.HasRows)
            {
                while (odbcDataReader.Read())
                {
                    // dataGridView1.Rows.Add(odbcDataReader[0].ToString(), odbcDataReader[1].ToString());
                    textBox1.Text += odbcDataReader[1].ToString() + Environment.NewLine;
                }
            }          
            odbcDataReader.Close();
        }
    }
}
