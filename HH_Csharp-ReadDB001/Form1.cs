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
        const string odbcConnectionString = "DSN=maria-simple-db"; // dsnname has been changed
        public Form1()
        {
            InitializeComponent(); //////
        } 

        private void Form1_Load(object sender, EventArgs e)
        {
            this.odbcConnection = new OdbcConnection(odbcConnectionString);
            this.odbcConnection.Open();
        }
    }
}
