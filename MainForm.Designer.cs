namespace SWE_Project
{
    partial class MainForm
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
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_pub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Magazine Management System";
            // 
            // btn_sub
            // 
            this.btn_sub.Location = new System.Drawing.Point(313, 78);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(117, 23);
            this.btn_sub.TabIndex = 1;
            this.btn_sub.Text = "Subscriber";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_pub
            // 
            this.btn_pub.Location = new System.Drawing.Point(313, 149);
            this.btn_pub.Name = "btn_pub";
            this.btn_pub.Size = new System.Drawing.Size(117, 23);
            this.btn_pub.TabIndex = 2;
            this.btn_pub.Text = "Publisher";
            this.btn_pub.UseVisualStyleBackColor = true;
            this.btn_pub.Click += new System.EventHandler(this.btn_pub_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_pub);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_pub;
    }
}

