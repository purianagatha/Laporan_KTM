namespace GUI_FindMyKTM.Forms
{
    partial class FormDetailLaporan
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
            this.labelstatus = new System.Windows.Forms.Label();
            this.labeltitle = new System.Windows.Forms.Label();
            this.labelstudentid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelstatus
            // 
            this.labelstatus.AutoSize = true;
            this.labelstatus.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.labelstatus.Location = new System.Drawing.Point(28, 66);
            this.labelstatus.Name = "labelstatus";
            this.labelstatus.Size = new System.Drawing.Size(112, 40);
            this.labelstatus.TabIndex = 1;
            this.labelstatus.Text = "Status";
            this.labelstatus.Click += new System.EventHandler(this.linktonama_Click);
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.labeltitle.Location = new System.Drawing.Point(35, 143);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(79, 40);
            this.labeltitle.TabIndex = 2;
            this.labeltitle.Text = "Title";
            // 
            // labelstudentid
            // 
            this.labelstudentid.AutoSize = true;
            this.labelstudentid.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.labelstudentid.Location = new System.Drawing.Point(35, 22);
            this.labelstudentid.Name = "labelstudentid";
            this.labelstudentid.Size = new System.Drawing.Size(85, 19);
            this.labelstudentid.TabIndex = 3;
            this.labelstudentid.Text = "StudentID";
            // 
            // FormDetailLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelstudentid);
            this.Controls.Add(this.labeltitle);
            this.Controls.Add(this.labelstatus);
            this.Name = "FormDetailLaporan";
            this.Text = "FormDetailLaporan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelstatus;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Label labelstudentid;
    }
}