using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace SWE_Project
{
    public partial class MainForm : Form
    {
        string ordb = "Data Source = orclpdb; User Id = MMS; Password = mms;";

        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            this.Hide();

            new SubLogin(ordb).ShowDialog();

            this.Show();
        }

        private void btn_pub_Click(object sender, EventArgs e)
        {
            this.Hide();

            new PubLogin(ordb).ShowDialog();

            this.Show();
        }
    }
}
