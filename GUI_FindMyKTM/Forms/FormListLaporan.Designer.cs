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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.listlaporan = new System.Windows.Forms.DataGridView();
            this.addbtn = new System.Windows.Forms.Button();
            this.editdeletebtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listlaporan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1105, 40);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(24)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listlaporan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listlaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listlaporan.DefaultCellStyle = dataGridViewCellStyle2;
            this.listlaporan.EnableHeadersVisualStyles = false;
            this.listlaporan.GridColor = System.Drawing.Color.White;
            this.listlaporan.Location = new System.Drawing.Point(25, 127);
            this.listlaporan.MultiSelect = false;
            this.listlaporan.Name = "listlaporan";
            this.listlaporan.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.listlaporan.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.listlaporan.RowHeadersVisible = false;
            this.listlaporan.RowHeadersWidth = 60;
            this.listlaporan.RowTemplate.Height = 24;
            this.listlaporan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listlaporan.Size = new System.Drawing.Size(1254, 462);
            this.listlaporan.TabIndex = 4;
            // 
            // addbtn
            // 
            this.addbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.addbtn.Location = new System.Drawing.Point(25, 33);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(180, 75);
            this.addbtn.TabIndex = 5;
            this.addbtn.Text = "Tambah Laporan";
            this.addbtn.UseVisualStyleBackColor = true;
            // 
            // editdeletebtn
            // 
            this.editdeletebtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.editdeletebtn.Location = new System.Drawing.Point(211, 33);
            this.editdeletebtn.Name = "editdeletebtn";
            this.editdeletebtn.Size = new System.Drawing.Size(180, 75);
            this.editdeletebtn.TabIndex = 6;
            this.editdeletebtn.Text = "Edit/Delete Laporan";
            this.editdeletebtn.UseVisualStyleBackColor = true;
            // 
            // searchbtn
            // 
            this.searchbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.searchbtn.Location = new System.Drawing.Point(398, 32);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(180, 75);
            this.searchbtn.TabIndex = 7;
            this.searchbtn.Text = "Search Laporan";
            this.searchbtn.UseVisualStyleBackColor = true;
            // 
            // FormListLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 625);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.editdeletebtn);
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
        private System.Windows.Forms.Button editdeletebtn;
        private System.Windows.Forms.Button searchbtn;
    }
}