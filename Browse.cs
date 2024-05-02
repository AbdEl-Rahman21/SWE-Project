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
    public partial class Browse : Form
    {
        OracleConnection connection = null;

        public Browse(string ordb)
        {
            InitializeComponent();

            connection = new OracleConnection(ordb);
        }

        private void Browse_Load(object sender, EventArgs e)
        {
            connection.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;

            cmd.CommandText = "GetCategories";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("categories", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cmb_category.Items.Add(reader[0]);
            }

            reader.Close();
        }

        private void cmb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;

            cmd.CommandText = "select magazine_name from magazines where m_category = :category";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("category", cmb_category.SelectedItem.ToString());

            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cmb_mag.Items.Add(reader[0]);
            }

            reader.Close();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            int done = 0;

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;

            cmd.CommandText = "update magazines set views = views + 1 where magazine_name = :mag_name";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("mag_name", cmb_mag.SelectedItem.ToString());

            done = cmd.ExecuteNonQuery();

            if (done != -1)
            {
                MessageBox.Show(cmb_mag.SelectedItem.ToString());
            }
        }

        private void Browse_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Dispose();
        }
    }
}
