using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE_Project
{
    public partial class SubLogin : Form
    {
        OracleConnection connection = null;

        public SubLogin(string ordb)
        {
            InitializeComponent();

            connection = new OracleConnection(ordb);
        }

        private void SubLogin_Load(object sender, EventArgs e)
        {
            connection.Open();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;

            cmd.CommandText = "select * from subscribers where username = :username and s_password = :password";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("username", txt_username.Text);
            cmd.Parameters.Add("password", txt_pass.Text);

            OracleDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                reader.Close();

                this.Hide();

                new Browse(connection.ConnectionString).ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Data!");
            }

            reader.Close();
        }

        private void SubLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Dispose();
        }
    }
}
