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
    public partial class MagRevenue : Form
    {
        string pubId = "";
        MagRevReport report = null;

        public MagRevenue(string pubId)
        {
            InitializeComponent();

            this.pubId = pubId;
        }

        private void MagRevenue_Load(object sender, EventArgs e)
        {
            report = new MagRevReport();

            foreach (ParameterDiscreteValue i in report.ParameterFields[1].DefaultValues)
            {
                cmb_category.Items.Add(i.Value);
            }
        }

        private void btn_gen_report_Click(object sender, EventArgs e)
        {
            report.SetParameterValue(0, Convert.ToInt32(pubId));
            report.SetParameterValue(1, cmb_category.Text);

            crystalReportViewer.ReportSource = report;
        }
    }
}
