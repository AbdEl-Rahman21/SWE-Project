namespace SWE_Project
{
    partial class MagRevenue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.btn_gen_report = new System.Windows.Forms.Button();
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Category";
            // 
            // cmb_category
            // 
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(493, 4);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(121, 24);
            this.cmb_category.TabIndex = 1;
            // 
            // btn_gen_report
            // 
            this.btn_gen_report.Location = new System.Drawing.Point(814, 4);
            this.btn_gen_report.Name = "btn_gen_report";
            this.btn_gen_report.Size = new System.Drawing.Size(138, 23);
            this.btn_gen_report.TabIndex = 2;
            this.btn_gen_report.Text = "Generate Report";
            this.btn_gen_report.UseVisualStyleBackColor = true;
            this.btn_gen_report.Click += new System.EventHandler(this.btn_gen_report_Click);
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = -1;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.Location = new System.Drawing.Point(12, 35);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.Size = new System.Drawing.Size(1334, 541);
            this.crystalReportViewer.TabIndex = 3;
            // 
            // MagRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 588);
            this.Controls.Add(this.crystalReportViewer);
            this.Controls.Add(this.btn_gen_report);
            this.Controls.Add(this.cmb_category);
            this.Controls.Add(this.label1);
            this.Name = "MagRevenue";
            this.Text = "MagRevenue";
            this.Load += new System.EventHandler(this.MagRevenue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.Button btn_gen_report;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
    }
}