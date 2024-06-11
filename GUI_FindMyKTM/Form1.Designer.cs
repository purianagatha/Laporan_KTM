namespace GUI_FindMyKTM
{
    partial class Form1
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEditDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(24)))), ((int)(((byte)(42)))));
            this.panelMenu.Controls.Add(this.btnProfile);
            this.panelMenu.Controls.Add(this.btnList);
            this.panelMenu.Controls.Add(this.btnSearch);
            this.panelMenu.Controls.Add(this.btnEditDelete);
            this.panelMenu.Controls.Add(this.btnCreate);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 585);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(20)))), ((int)(((byte)(35)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // btnProfile
            // 
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProfile.Image = global::GUI_FindMyKTM.Properties.Resources.icons8_user_24;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(0, 320);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnProfile.Size = new System.Drawing.Size(220, 60);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "   Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnList
            // 
            this.btnList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnList.Image = global::GUI_FindMyKTM.Properties.Resources.icons8_list_24;
            this.btnList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList.Location = new System.Drawing.Point(0, 260);
            this.btnList.Name = "btnList";
            this.btnList.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnList.Size = new System.Drawing.Size(220, 60);
            this.btnList.TabIndex = 3;
            this.btnList.Text = "   List Laporan";
            this.btnList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnList.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.Image = global::GUI_FindMyKTM.Properties.Resources.icons8_search_24;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(0, 200);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(220, 60);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "   Search Laporan";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnEditDelete
            // 
            this.btnEditDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditDelete.FlatAppearance.BorderSize = 0;
            this.btnEditDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDelete.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditDelete.Image = global::GUI_FindMyKTM.Properties.Resources.icons8_delete_document_24;
            this.btnEditDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditDelete.Location = new System.Drawing.Point(0, 140);
            this.btnEditDelete.Name = "btnEditDelete";
            this.btnEditDelete.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnEditDelete.Size = new System.Drawing.Size(220, 60);
            this.btnEditDelete.TabIndex = 1;
            this.btnEditDelete.Text = "   Edit/Delete ";
            this.btnEditDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditDelete.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCreate.Image = global::GUI_FindMyKTM.Properties.Resources.icons8_create_24;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(0, 80);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCreate.Size = new System.Drawing.Size(220, 60);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "   Create Laporan";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 585);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEditDelete;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnProfile;
    }
}

