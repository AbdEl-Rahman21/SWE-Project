namespace SWE_Project
{
    partial class PubMenu
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
            this.btn_pub_mag = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_follower_info = new System.Windows.Forms.Button();
            this.btn_mag_rev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Publisher Menu";
            // 
            // btn_pub_mag
            // 
            this.btn_pub_mag.Location = new System.Drawing.Point(214, 71);
            this.btn_pub_mag.Name = "btn_pub_mag";
            this.btn_pub_mag.Size = new System.Drawing.Size(140, 23);
            this.btn_pub_mag.TabIndex = 1;
            this.btn_pub_mag.Text = "Publish Magazine";
            this.btn_pub_mag.UseVisualStyleBackColor = true;
            this.btn_pub_mag.Click += new System.EventHandler(this.btn_pub_mag_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(408, 71);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(124, 23);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Edit Magazines";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_follower_info
            // 
            this.btn_follower_info.Location = new System.Drawing.Point(188, 117);
            this.btn_follower_info.Name = "btn_follower_info";
            this.btn_follower_info.Size = new System.Drawing.Size(185, 23);
            this.btn_follower_info.TabIndex = 3;
            this.btn_follower_info.Text = "View Follower Information";
            this.btn_follower_info.UseVisualStyleBackColor = true;
            this.btn_follower_info.Click += new System.EventHandler(this.btn_follower_info_Click);
            // 
            // btn_mag_rev
            // 
            this.btn_mag_rev.Location = new System.Drawing.Point(379, 117);
            this.btn_mag_rev.Name = "btn_mag_rev";
            this.btn_mag_rev.Size = new System.Drawing.Size(193, 23);
            this.btn_mag_rev.TabIndex = 4;
            this.btn_mag_rev.Text = "View Magazine Revenue";
            this.btn_mag_rev.UseVisualStyleBackColor = true;
            this.btn_mag_rev.Click += new System.EventHandler(this.btn_mag_rev_Click);
            // 
            // PubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_mag_rev);
            this.Controls.Add(this.btn_follower_info);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_pub_mag);
            this.Controls.Add(this.label1);
            this.Name = "PubMenu";
            this.Text = "PubMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_pub_mag;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_follower_info;
        private System.Windows.Forms.Button btn_mag_rev;
    }
}