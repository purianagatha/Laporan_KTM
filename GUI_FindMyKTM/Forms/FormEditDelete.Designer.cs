namespace GUI_FindMyKTM.Forms
{
    partial class FormEditDelete
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
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PlaceHolderNama = new System.Windows.Forms.Label();
            this.LabelNim = new System.Windows.Forms.Label();
            this.LabelAlasan = new System.Windows.Forms.Label();
            this.ButtonCari = new System.Windows.Forms.Button();
            this.ButtonProses = new System.Windows.Forms.Button();
            this.ButtonBermasalh = new System.Windows.Forms.Button();
            this.LabelProses = new System.Windows.Forms.Label();
            this.LabelSelamat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(366, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Alasan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "NIM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nama Lengkap Mahasiswa";
            // 
            // PlaceHolderNama
            // 
            this.PlaceHolderNama.AutoSize = true;
            this.PlaceHolderNama.Location = new System.Drawing.Point(9, 137);
            this.PlaceHolderNama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlaceHolderNama.Name = "PlaceHolderNama";
            this.PlaceHolderNama.Size = new System.Drawing.Size(93, 13);
            this.PlaceHolderNama.TabIndex = 15;
            this.PlaceHolderNama.Text = "PlaceHolderNama";
            this.PlaceHolderNama.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // LabelNim
            // 
            this.LabelNim.AutoSize = true;
            this.LabelNim.Location = new System.Drawing.Point(11, 204);
            this.LabelNim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelNim.Name = "LabelNim";
            this.LabelNim.Size = new System.Drawing.Size(51, 13);
            this.LabelNim.TabIndex = 16;
            this.LabelNim.Text = "LabelNim";
            this.LabelNim.Click += new System.EventHandler(this.label7_Click);
            // 
            // LabelAlasan
            // 
            this.LabelAlasan.AutoSize = true;
            this.LabelAlasan.Location = new System.Drawing.Point(367, 137);
            this.LabelAlasan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelAlasan.Name = "LabelAlasan";
            this.LabelAlasan.Size = new System.Drawing.Size(65, 13);
            this.LabelAlasan.TabIndex = 19;
            this.LabelAlasan.Text = "LabelAlasan";
            // 
            // ButtonCari
            // 
            this.ButtonCari.Location = new System.Drawing.Point(47, 46);
            this.ButtonCari.Name = "ButtonCari";
            this.ButtonCari.Size = new System.Drawing.Size(75, 23);
            this.ButtonCari.TabIndex = 20;
            this.ButtonCari.Text = "Cari";
            this.ButtonCari.UseVisualStyleBackColor = true;
            this.ButtonCari.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonProses
            // 
            this.ButtonProses.Location = new System.Drawing.Point(175, 46);
            this.ButtonProses.Name = "ButtonProses";
            this.ButtonProses.Size = new System.Drawing.Size(75, 23);
            this.ButtonProses.TabIndex = 21;
            this.ButtonProses.Text = "Proses";
            this.ButtonProses.UseVisualStyleBackColor = true;
            this.ButtonProses.Click += new System.EventHandler(this.ButtonProsess);
            // 
            // ButtonBermasalh
            // 
            this.ButtonBermasalh.Location = new System.Drawing.Point(295, 46);
            this.ButtonBermasalh.Name = "ButtonBermasalh";
            this.ButtonBermasalh.Size = new System.Drawing.Size(75, 23);
            this.ButtonBermasalh.TabIndex = 22;
            this.ButtonBermasalh.Text = "Bermasalah";
            this.ButtonBermasalh.UseVisualStyleBackColor = true;
            this.ButtonBermasalh.Click += new System.EventHandler(this.ButtonBermasalh_Click);
            // 
            // LabelProses
            // 
            this.LabelProses.AutoSize = true;
            this.LabelProses.Location = new System.Drawing.Point(439, 37);
            this.LabelProses.Name = "LabelProses";
            this.LabelProses.Size = new System.Drawing.Size(41, 13);
            this.LabelProses.TabIndex = 23;
            this.LabelProses.Text = "label11";
            // 
            // LabelSelamat
            // 
            this.LabelSelamat.AutoSize = true;
            this.LabelSelamat.Location = new System.Drawing.Point(439, 66);
            this.LabelSelamat.Name = "LabelSelamat";
            this.LabelSelamat.Size = new System.Drawing.Size(85, 13);
            this.LabelSelamat.TabIndex = 24;
            this.LabelSelamat.Text = "Selamat Berhasil";
            this.LabelSelamat.Click += new System.EventHandler(this.label12_Click);
            // 
            // FormEditDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 372);
            this.Controls.Add(this.LabelSelamat);
            this.Controls.Add(this.LabelProses);
            this.Controls.Add(this.ButtonBermasalh);
            this.Controls.Add(this.ButtonProses);
            this.Controls.Add(this.ButtonCari);
            this.Controls.Add(this.LabelAlasan);
            this.Controls.Add(this.LabelNim);
            this.Controls.Add(this.PlaceHolderNama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEditDelete";
            this.Text = "FormEditDelete";
            this.Load += new System.EventHandler(this.FormEditDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PlaceHolderNama;
        private System.Windows.Forms.Label LabelNim;
        private System.Windows.Forms.Label LabelAlasan;
        private System.Windows.Forms.Button ButtonCari;
        private System.Windows.Forms.Button ButtonProses;
        private System.Windows.Forms.Button ButtonBermasalh;
        private System.Windows.Forms.Label LabelProses;
        private System.Windows.Forms.Label LabelSelamat;
    }
}