namespace GUI_FindMyKTM.Forms
{
    partial class FormListLaporan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.listlaporan = new System.Windows.Forms.DataGridView();
            this.addbtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listlaporan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(962, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "INI PAGE LIST LAPORAN";
            // 
            // listlaporan
            // 
            this.listlaporan.AllowUserToAddRows = false;
            this.listlaporan.AllowUserToDeleteRows = false;
            this.listlaporan.AllowUserToResizeColumns = false;
            this.listlaporan.AllowUserToResizeRows = false;
            this.listlaporan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.listlaporan.BackgroundColor = System.Drawing.Color.White;
            this.listlaporan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listlaporan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(24)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listlaporan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.listlaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listlaporan.DefaultCellStyle = dataGridViewCellStyle5;
            this.listlaporan.EnableHeadersVisualStyles = false;
            this.listlaporan.GridColor = System.Drawing.Color.White;
            this.listlaporan.Location = new System.Drawing.Point(25, 127);
            this.listlaporan.MultiSelect = false;
            this.listlaporan.Name = "listlaporan";
            this.listlaporan.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.listlaporan.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.listlaporan.RowHeadersVisible = false;
            this.listlaporan.RowHeadersWidth = 60;
            this.listlaporan.RowTemplate.Height = 24;
            this.listlaporan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listlaporan.Size = new System.Drawing.Size(1098, 465);
            this.listlaporan.TabIndex = 4;
            this.listlaporan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listlaporan_CellContentClick);
            // 
            // addbtn
            // 
            this.addbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.addbtn.Location = new System.Drawing.Point(25, 32);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(180, 75);
            this.addbtn.TabIndex = 5;
            this.addbtn.Text = "Tambah Laporan";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.editbtn.Location = new System.Drawing.Point(211, 33);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(180, 75);
            this.editbtn.TabIndex = 6;
            this.editbtn.Text = "Edit Laporan";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editdeletebtn_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.searchbtn.Location = new System.Drawing.Point(584, 33);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(180, 75);
            this.searchbtn.TabIndex = 7;
            this.searchbtn.Text = "Search Laporan";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.deletebtn.Location = new System.Drawing.Point(398, 33);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(180, 75);
            this.deletebtn.TabIndex = 8;
            this.deletebtn.Text = "Delete Laporan";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // FormListLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 625);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.listlaporan);
            this.Controls.Add(this.label1);
            this.Name = "FormListLaporan";
            this.Text = "FormListLaporan";
            ((System.ComponentModel.ISupportInitialize)(this.listlaporan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listlaporan;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button deletebtn;
    }
}