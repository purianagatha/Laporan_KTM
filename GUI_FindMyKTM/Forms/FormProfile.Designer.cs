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
            this.PlaceHolder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelNim
            // 
            this.LabelNim.AutoSize = true;
            this.LabelNim.Location = new System.Drawing.Point(44, 181);
            this.LabelNim.Name = "LabelNim";
            this.LabelNim.Size = new System.Drawing.Size(23, 13);
            this.LabelNim.TabIndex = 1;
            this.LabelNim.Text = "nim";
            this.LabelNim.Click += new System.EventHandler(this.label2_Click);
            // 
            // LabelNama
            // 
            this.LabelNama.AutoSize = true;
            this.LabelNama.Location = new System.Drawing.Point(44, 71);
            this.LabelNama.Name = "LabelNama";
            this.LabelNama.Size = new System.Drawing.Size(35, 13);
            this.LabelNama.TabIndex = 2;
            this.LabelNama.Text = "Nama";
            this.LabelNama.Click += new System.EventHandler(this.label3_Click);
            // 
            // PlaceHolder
            // 
            this.PlaceHolder.AutoSize = true;
            this.PlaceHolder.Location = new System.Drawing.Point(101, 71);
            this.PlaceHolder.Name = "PlaceHolder";
            this.PlaceHolder.Size = new System.Drawing.Size(35, 13);
            this.PlaceHolder.TabIndex = 3;
            this.PlaceHolder.Text = "Nama";
            this.PlaceHolder.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 372);
            this.Controls.Add(this.PlaceHolder);
            this.Controls.Add(this.LabelNama);
            this.Controls.Add(this.LabelNim);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label PlaceHolder;
    }
}