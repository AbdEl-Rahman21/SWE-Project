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
    public partial class EditMag : Form
    {
        string pubId = "";
        string ordb = "";

        OracleDataAdapter adapter = null;
        OracleCommandBuilder builder = null;
        DataSet dataSet = null;

        public EditMag(string ordb, string id)
        {
            InitializeComponent();

            this.pubId = id;
            this.ordb = ordb;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string cmdText = @"select magazine_id, magazine_name, publication_date, m_category
                               from magazines
                               where publisher_id = :pId and m_category = :category";

            adapter = new OracleDataAdapter(cmdText, ordb);

            adapter.SelectCommand.Parameters.Add("pId", pubId);
            adapter.SelectCommand.Parameters.Add("category", txt_category.Text);

            dataSet = new DataSet();

            adapter.Fill(dataSet);

            dataGridView.DataSource = dataSet.Tables[0];
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);

            adapter.Update(dataSet.Tables[0]);
        }
    }
}
