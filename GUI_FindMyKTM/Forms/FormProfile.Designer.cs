namespace GUI_FindMyKTM.Forms
{
    partial class FormProfile
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
            this.LabelNim = new System.Windows.Forms.Label();
            this.LabelNama = new System.Windows.Forms.Label();
            this.tempatNama = new System.Windows.Forms.Label();
            this.tempatNim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 269);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelNim
            // 
            this.LabelNim.AutoSize = true;
            this.LabelNim.Location = new System.Drawing.Point(88, 348);
            this.LabelNim.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelNim.Name = "LabelNim";
            this.LabelNim.Size = new System.Drawing.Size(46, 25);
            this.LabelNim.TabIndex = 1;
            this.LabelNim.Text = "nim";
            this.LabelNim.Click += new System.EventHandler(this.label2_Click);
            // 
            // LabelNama
            // 
            this.LabelNama.AutoSize = true;
            this.LabelNama.Location = new System.Drawing.Point(88, 137);
            this.LabelNama.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelNama.Name = "LabelNama";
            this.LabelNama.Size = new System.Drawing.Size(68, 25);
            this.LabelNama.TabIndex = 2;
            this.LabelNama.Text = "Nama";
            this.LabelNama.Click += new System.EventHandler(this.label3_Click);
            // 
            // tempatNama
            // 
            this.tempatNama.AutoSize = true;
            this.tempatNama.Location = new System.Drawing.Point(88, 213);
            this.tempatNama.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tempatNama.Name = "tempatNama";
            this.tempatNama.Size = new System.Drawing.Size(140, 25);
            this.tempatNama.TabIndex = 3;
            this.tempatNama.Text = "TempatNama";
            this.tempatNama.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // tempatNim
            // 
            this.tempatNim.AutoSize = true;
            this.tempatNim.Location = new System.Drawing.Point(93, 431);
            this.tempatNim.Name = "tempatNim";
            this.tempatNim.Size = new System.Drawing.Size(70, 25);
            this.tempatNim.TabIndex = 4;
            this.tempatNim.Text = "label3";
            this.tempatNim.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 715);
            this.Controls.Add(this.tempatNim);
            this.Controls.Add(this.tempatNama);
            this.Controls.Add(this.LabelNama);
            this.Controls.Add(this.LabelNim);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormProfile";
            this.Text = "FormLaporan";
            this.Load += new System.EventHandler(this.FormProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelNim;
        private System.Windows.Forms.Label LabelNama;
        private System.Windows.Forms.Label tempatNama;
        private System.Windows.Forms.Label tempatNim;
    }
}