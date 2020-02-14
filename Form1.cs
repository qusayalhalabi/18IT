using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cam_inloggning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection con;
            connectionString = @"Data Source=CND8263Q4K\QUSAYSQL; Initial Catalog = Prog1;Integrated Security=True";
            con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            string sql, output = "";

            sql = "SELECT Text FROM GUIContents";
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();

            dataReader.Read();
            label1.Text = (dataReader["Text"].ToString());
            label2.Text = (dataReader["Text"].ToString());
            con.Close();
        }
    }
}
