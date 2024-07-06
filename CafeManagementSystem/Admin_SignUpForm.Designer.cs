﻿namespace CafeManagementSystem
{
    partial class Admin_SignUpForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.firstnamebox = new System.Windows.Forms.RichTextBox();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.lastnamebox = new System.Windows.Forms.RichTextBox();
            this.lastnamelabel = new System.Windows.Forms.Label();
            this.emailbox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordbox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phonebox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SignUpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoEllipsis = true;
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.DimGray;
            this.NameLabel.Location = new System.Drawing.Point(162, 185);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(191, 52);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "CafeVue";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CafeManagementSystem.Properties.Resources.logo1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(171, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 171);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // firstnamebox
            // 
            this.firstnamebox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.firstnamebox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstnamebox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnamebox.Location = new System.Drawing.Point(82, 332);
            this.firstnamebox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstnamebox.Name = "firstnamebox";
            this.firstnamebox.Size = new System.Drawing.Size(380, 46);
            this.firstnamebox.TabIndex = 11;
            this.firstnamebox.Text = "";
            this.firstnamebox.TextChanged += new System.EventHandler(this.EmailBox_TextChanged);
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameLabel.ForeColor = System.Drawing.Color.DimGray;
            this.firstnameLabel.Location = new System.Drawing.Point(80, 285);
            this.firstnameLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(140, 32);
            this.firstnameLabel.TabIndex = 10;
            this.firstnameLabel.Text = "First Name";
            this.firstnameLabel.Click += new System.EventHandler(this.EmailLabel_Click);
            // 
            // lastnamebox
            // 
            this.lastnamebox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lastnamebox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastnamebox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnamebox.Location = new System.Drawing.Point(80, 432);
            this.lastnamebox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastnamebox.Name = "lastnamebox";
            this.lastnamebox.Size = new System.Drawing.Size(380, 46);
            this.lastnamebox.TabIndex = 13;
            this.lastnamebox.Text = "";
            this.lastnamebox.TextChanged += new System.EventHandler(this.lastnamebox_TextChanged);
            // 
            // lastnamelabel
            // 
            this.lastnamelabel.AutoSize = true;
            this.lastnamelabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnamelabel.ForeColor = System.Drawing.Color.DimGray;
            this.lastnamelabel.Location = new System.Drawing.Point(76, 385);
            this.lastnamelabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastnamelabel.Name = "lastnamelabel";
            this.lastnamelabel.Size = new System.Drawing.Size(135, 32);
            this.lastnamelabel.TabIndex = 12;
            this.lastnamelabel.Text = "Last Name";
            // 
            // emailbox
            // 
            this.emailbox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.emailbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailbox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailbox.Location = new System.Drawing.Point(80, 535);
            this.emailbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(380, 46);
            this.emailbox.TabIndex = 15;
            this.emailbox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(80, 488);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Email";
            // 
            // passwordbox
            // 
            this.passwordbox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.passwordbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordbox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordbox.Location = new System.Drawing.Point(82, 638);
            this.passwordbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(380, 46);
            this.passwordbox.TabIndex = 17;
            this.passwordbox.Text = "";
            this.passwordbox.TextChanged += new System.EventHandler(this.passwordbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(80, 591);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Password";
            // 
            // phonebox
            // 
            this.phonebox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.phonebox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phonebox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonebox.Location = new System.Drawing.Point(82, 742);
            this.phonebox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phonebox.Name = "phonebox";
            this.phonebox.Size = new System.Drawing.Size(380, 46);
            this.phonebox.TabIndex = 19;
            this.phonebox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(80, 694);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(94, 897);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Already Have an Account. Login";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.AutoSize = true;
            this.SignUpButton.BackColor = System.Drawing.Color.Silver;
            this.SignUpButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.SignUpButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.Location = new System.Drawing.Point(192, 825);
            this.SignUpButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(132, 52);
            this.SignUpButton.TabIndex = 20;
            this.SignUpButton.Text = "Sign up";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // Admin_SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(536, 1002);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.phonebox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastnamebox);
            this.Controls.Add(this.lastnamelabel);
            this.Controls.Add(this.firstnamebox);
            this.Controls.Add(this.firstnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Admin_SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox firstnamebox;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.RichTextBox lastnamebox;
        private System.Windows.Forms.Label lastnamelabel;
        private System.Windows.Forms.RichTextBox emailbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox passwordbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox phonebox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SignUpButton;
    }
}