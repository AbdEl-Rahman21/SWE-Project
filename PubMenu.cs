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
        string pubId = "";

        OracleConnection connection = null;

        public PubMenu(string ordb, string id)
        {
            InitializeComponent();

            this.ordb = ordb;
            this.pubId = id;

            connection = new OracleConnection(ordb);
        }

        private void btn_pub_mag_Click(object sender, EventArgs e)
        {
            this.Hide();

            new PublishMag(ordb, pubId).ShowDialog();

            this.Show();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            this.Hide();

            new EditMag(ordb, pubId).ShowDialog();

            this.Show();
        }

        private void btn_follower_info_Click(object sender, EventArgs e)
        {
            this.Hide();

            new FollowerInfo(pubId).ShowDialog();

            this.Show();
        }

        private void btn_mag_rev_Click(object sender, EventArgs e)
        {
            this.Hide();

            new MagRevenue(pubId).ShowDialog();

            this.Show();
        }
    }
}
