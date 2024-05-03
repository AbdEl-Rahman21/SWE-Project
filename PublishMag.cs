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
    public partial class PublishMag : Form
    {
        string pub_id = "";
        int newMagId = 0;

        OracleConnection connection = null;

        public PublishMag(string ordb, string id)
        {
            InitializeComponent();

            this.pub_id = id;
            connection = new OracleConnection(ordb);
        }

        private void PublishMag_Load(object sender, EventArgs e)
        {
            connection.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;

            cmd.CommandText = "GetMagId";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("magId", OracleDbType.Int32, ParameterDirection.Output);

            cmd.ExecuteNonQuery();

            try
            {
                newMagId = Convert.ToInt32(cmd.Parameters["magId"].Value.ToString()) + 1;
            }
            catch
            {
                newMagId = 1;
            }
        }

        private void btn_publish_Click(object sender, EventArgs e)
        {
            int done = 0;

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;

            cmd.CommandText = "insert into magazines values (:id, :pubId, :name, :pubDate, 0, :category)";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("id", newMagId.ToString());
            cmd.Parameters.Add("pubId", pub_id);
            cmd.Parameters.Add("name", txt_name.Text);
            cmd.Parameters.Add("pubDate", DateTime.Now);
            cmd.Parameters.Add("category", txt_category.Text);

            done = cmd.ExecuteNonQuery();

            if(done != -1)
            {
                MessageBox.Show("Magazine Published!");
            }
        }

        private void PublishMag_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Dispose();
        }
    }
}
