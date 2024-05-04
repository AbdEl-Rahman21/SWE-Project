using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace SWE_Project
{
    public partial class FollowerInfo : Form
    {
        string pubId = "";
        FollowerInfoReport report = null;

        public FollowerInfo(string pubId)
        {
            InitializeComponent();

            this.pubId = pubId;
        }

        private void FollowerInfo_Load(object sender, EventArgs e)
        {
            report = new FollowerInfoReport();

            report.SetParameterValue(0, Convert.ToInt32(pubId));

            crystalReportViewer.ReportSource = report;
        }
    }
}
