using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace simpleConnectiontoSQLS2008
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=KEKA-PC;Initial Catalog=connectToCs;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open) {

                SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO studentsApp VALUES('"+textBox1.Text+"', '"+textBox2.Text+"')", conn);
                sda.SelectCommand.ExecuteNonQuery();
                button1.BackColor = Color.Green;
                MessageBox.Show("Successfully, Added!");
                conn.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                button1.BackColor = Color.Gainsboro;
            }
        }
    }
}
