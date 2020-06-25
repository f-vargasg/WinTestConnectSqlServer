using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTestConnectSqlServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butConnect_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=WIN-3VU0IUD67IK\SQLEXPRESS;Initial Catalog=Agenda;User ID=sa;Password=Flpvrgs1966";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                MessageBox.Show("Connection Open  !");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
