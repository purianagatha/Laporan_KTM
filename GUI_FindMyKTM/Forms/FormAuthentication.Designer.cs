﻿namespace GUI_FindMyKTM.Forms
{
    partial class FormAuthentication
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fieldEmail = new System.Windows.Forms.TextBox();
            this.fieldNim = new System.Windows.Forms.TextBox();
            this.fieldFaculty = new System.Windows.Forms.TextBox();
            this.fieldUsername = new System.Windows.Forms.TextBox();
            this.fieldName = new System.Windows.Forms.TextBox();
            this.fieldConfirmPassword = new System.Windows.Forms.TextBox();
            this.fieldPassword = new System.Windows.Forms.TextBox();
            this.fieldPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.loginEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1164, 692);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.fieldPhone);
            this.tabPage1.Controls.Add(this.fieldPassword);
            this.tabPage1.Controls.Add(this.fieldConfirmPassword);
            this.tabPage1.Controls.Add(this.fieldName);
            this.tabPage1.Controls.Add(this.fieldUsername);
            this.tabPage1.Controls.Add(this.fieldFaculty);
            this.tabPage1.Controls.Add(this.fieldNim);
            this.tabPage1.Controls.Add(this.fieldEmail);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnRegister);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1156, 655);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Register";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLogin);
            this.tabPage2.Controls.Add(this.loginPassword);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.loginEmail);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1156, 655);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Login";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(34, 523);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(345, 52);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Buat Akun";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email SSO :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "NIM :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fakultas :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(574, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nomor Telepon :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(574, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Password :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(574, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Konfirmasi Password :";
            // 
            // fieldEmail
            // 
            this.fieldEmail.Location = new System.Drawing.Point(172, 221);
            this.fieldEmail.Name = "fieldEmail";
            this.fieldEmail.Size = new System.Drawing.Size(300, 29);
            this.fieldEmail.TabIndex = 9;
            // 
            // fieldNim
            // 
            this.fieldNim.Location = new System.Drawing.Point(172, 318);
            this.fieldNim.Name = "fieldNim";
            this.fieldNim.Size = new System.Drawing.Size(300, 29);
            this.fieldNim.TabIndex = 10;
            // 
            // fieldFaculty
            // 
            this.fieldFaculty.Location = new System.Drawing.Point(172, 402);
            this.fieldFaculty.Name = "fieldFaculty";
            this.fieldFaculty.Size = new System.Drawing.Size(300, 29);
            this.fieldFaculty.TabIndex = 11;
            // 
            // fieldUsername
            // 
            this.fieldUsername.Location = new System.Drawing.Point(172, 142);
            this.fieldUsername.Name = "fieldUsername";
            this.fieldUsername.Size = new System.Drawing.Size(300, 29);
            this.fieldUsername.TabIndex = 12;
            // 
            // fieldName
            // 
            this.fieldName.Location = new System.Drawing.Point(172, 55);
            this.fieldName.Name = "fieldName";
            this.fieldName.Size = new System.Drawing.Size(300, 29);
            this.fieldName.TabIndex = 13;
            // 
            // fieldConfirmPassword
            // 
            this.fieldConfirmPassword.Location = new System.Drawing.Point(817, 223);
            this.fieldConfirmPassword.Name = "fieldConfirmPassword";
            this.fieldConfirmPassword.Size = new System.Drawing.Size(300, 29);
            this.fieldConfirmPassword.TabIndex = 14;
            this.fieldConfirmPassword.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // fieldPassword
            // 
            this.fieldPassword.Location = new System.Drawing.Point(817, 138);
            this.fieldPassword.Name = "fieldPassword";
            this.fieldPassword.Size = new System.Drawing.Size(300, 29);
            this.fieldPassword.TabIndex = 15;
            // 
            // fieldPhone
            // 
            this.fieldPhone.Location = new System.Drawing.Point(817, 55);
            this.fieldPhone.Name = "fieldPhone";
            this.fieldPhone.Size = new System.Drawing.Size(300, 29);
            this.fieldPhone.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(346, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Email SSO ";
            // 
            // loginEmail
            // 
            this.loginEmail.Location = new System.Drawing.Point(351, 143);
            this.loginEmail.Name = "loginEmail";
            this.loginEmail.Size = new System.Drawing.Size(400, 29);
            this.loginEmail.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(346, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Password";
            // 
            // loginPassword
            // 
            this.loginPassword.Location = new System.Drawing.Point(351, 254);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.Size = new System.Drawing.Size(400, 29);
            this.loginPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(351, 348);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(400, 39);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Masuk Akun";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // FormAuthentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 687);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAuthentication";
            this.Text = "FormAuthentication";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox fieldConfirmPassword;
        private System.Windows.Forms.TextBox fieldName;
        private System.Windows.Forms.TextBox fieldUsername;
        private System.Windows.Forms.TextBox fieldFaculty;
        private System.Windows.Forms.TextBox fieldNim;
        private System.Windows.Forms.TextBox fieldEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox fieldPhone;
        private System.Windows.Forms.TextBox fieldPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox loginEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox loginPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}