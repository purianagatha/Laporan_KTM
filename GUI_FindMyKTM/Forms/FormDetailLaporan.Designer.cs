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
            this.labelstudentid = new System.Windows.Forms.Label();
            this.labeltitle = new System.Windows.Forms.Label();
            this.labeldescription = new System.Windows.Forms.Label();
            this.labelcreatedat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelstatus
            // 
            this.labelstatus.AutoSize = true;
            this.labelstatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelstatus.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.labelstatus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelstatus.Location = new System.Drawing.Point(35, 390);
            this.labelstatus.Name = "labelstatus";
            this.labelstatus.Size = new System.Drawing.Size(85, 31);
            this.labelstatus.TabIndex = 1;
            this.labelstatus.Text = "Status";
            this.labelstatus.Click += new System.EventHandler(this.linktonama_Click);
            // 
            // labelstudentid
            // 
            this.labelstudentid.AutoSize = true;
            this.labelstudentid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelstudentid.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.labelstudentid.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelstudentid.Location = new System.Drawing.Point(36, 39);
            this.labelstudentid.Name = "labelstudentid";
            this.labelstudentid.Size = new System.Drawing.Size(73, 19);
            this.labelstudentid.TabIndex = 3;
            this.labelstudentid.Text = "StudentID";
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labeltitle.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.labeltitle.Location = new System.Drawing.Point(36, 121);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(81, 42);
            this.labeltitle.TabIndex = 4;
            this.labeltitle.Text = "Title";
            // 
            // labeldescription
            // 
            this.labeldescription.AutoSize = true;
            this.labeldescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labeldescription.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.labeldescription.Location = new System.Drawing.Point(35, 275);
            this.labeldescription.Name = "labeldescription";
            this.labeldescription.Size = new System.Drawing.Size(86, 19);
            this.labeldescription.TabIndex = 5;
            this.labeldescription.Text = "Description";
            this.labeldescription.Click += new System.EventHandler(this.labeldescription_Click);
            // 
            // labelcreatedat
            // 
            this.labelcreatedat.AutoSize = true;
            this.labelcreatedat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelcreatedat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelcreatedat.Location = new System.Drawing.Point(628, 403);
            this.labelcreatedat.Name = "labelcreatedat";
            this.labelcreatedat.Size = new System.Drawing.Size(72, 18);
            this.labelcreatedat.TabIndex = 6;
            this.labelcreatedat.Text = "Created At";
            this.labelcreatedat.Click += new System.EventHandler(this.labelcreatedat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Student Id";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(37, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Description";
            // 
            // FormDetailLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelcreatedat);
            this.Controls.Add(this.labeldescription);
            this.Controls.Add(this.labeltitle);
            this.Controls.Add(this.labelstudentid);
            this.Controls.Add(this.labelstatus);
            this.Name = "FormDetailLaporan";
            this.Text = "FormDetailLaporan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelstatus;
        private System.Windows.Forms.Label labelstudentid;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Label labeldescription;
        private System.Windows.Forms.Label labelcreatedat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}