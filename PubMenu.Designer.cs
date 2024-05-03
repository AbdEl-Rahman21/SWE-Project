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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(247, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(435, 117);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // PubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}