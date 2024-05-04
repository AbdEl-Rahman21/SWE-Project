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
    public partial class PubMenu : Form
    {
        string ordb = "";
        string pub_id = "";

        OracleConnection connection = null;

        public PubMenu(string ordb, string id)
        {
            InitializeComponent();

            this.ordb = ordb;
            this.pub_id = id;

            connection = new OracleConnection(ordb);
        }

        private void btn_pub_mag_Click(object sender, EventArgs e)
        {
            this.Hide();

            new PublishMag(ordb, pub_id).ShowDialog();

            this.Show();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            this.Hide();

            new EditMag(ordb, pub_id).ShowDialog();

            this.Show();
        }

        private void btn_follower_info_Click(object sender, EventArgs e)
        {
            this.Hide();

            new FollowerInfo(pub_id).ShowDialog();

            this.Show();
        }
    }
}
