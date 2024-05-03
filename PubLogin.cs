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
    public partial class PubLogin : Form
    {
        string ordb = "";

        OracleConnection connection = null;

        public PubLogin(string ordb)
        {
            InitializeComponent();

            this.ordb = ordb;
            connection = new OracleConnection(ordb);
        }

        private void PubLogin_Load(object sender, EventArgs e)
        {
            connection.Open();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string id = "";

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;

            cmd.CommandText = "select publisher_id from publishers where email = :email and p_password = :password";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("email", txt_email.Text);
            cmd.Parameters.Add("password", txt_pass.Text);

            OracleDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                id = reader[0].ToString();

                reader.Close();

                this.Hide();

                new PubMenu(ordb, id).ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Data!");
            }

            reader.Close();
        }

        private void PubLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Dispose();
        }
    }
}
