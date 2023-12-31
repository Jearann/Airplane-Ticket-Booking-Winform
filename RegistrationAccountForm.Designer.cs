﻿namespace AirTicketBookingWindowForm
{
    partial class RegistrationAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationAccountForm));
            picLogo = new PictureBox();
            lblTitle = new Label();
            label1 = new Label();
            txtCustomerName = new TextBox();
            label2 = new Label();
            dteBirthday = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            txtCustomerPassPort = new TextBox();
            label5 = new Label();
            txtCustomerNationality = new TextBox();
            picCustomerAvatar = new PictureBox();
            btnBrowser = new Button();
            btnRemove = new Button();
            rdbCertify = new RadioButton();
            btnRegist = new Button();
            btnCancel = new Button();
            lblClearFields = new Label();
            lblLogIn = new Label();
            label6 = new Label();
            txtPassword = new TextBox();
            label7 = new Label();
            txtUserName = new TextBox();
            label8 = new Label();
            txtConfirmPassword = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCustomerAvatar).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(12, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(100, 50);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTitle.Location = new Point(133, 75);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(233, 37);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Registration";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(110, 20);
            label1.Name = "label1";
            label1.Size = new Size(341, 37);
            label1.TabIndex = 2;
            label1.Text = "TIMBERLAND AIRLINE";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(111, 250);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(340, 23);
            txtCustomerName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(15, 251);
            label2.Name = "label2";
            label2.Size = new Size(88, 18);
            label2.TabIndex = 4;
            label2.Text = "Full Name:";
            // 
            // dteBirthday
            // 
            dteBirthday.Location = new Point(110, 288);
            dteBirthday.Name = "dteBirthday";
            dteBirthday.Size = new Size(219, 23);
            dteBirthday.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(15, 288);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 4;
            label3.Text = "Birthday:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(15, 325);
            label4.Name = "label4";
            label4.Size = new Size(88, 18);
            label4.TabIndex = 4;
            label4.Text = "Pass Port:";
            // 
            // txtCustomerPassPort
            // 
            txtCustomerPassPort.Location = new Point(110, 325);
            txtCustomerPassPort.Name = "txtCustomerPassPort";
            txtCustomerPassPort.Size = new Size(341, 23);
            txtCustomerPassPort.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(15, 363);
            label5.Name = "label5";
            label5.Size = new Size(104, 18);
            label5.TabIndex = 4;
            label5.Text = "Nationality:";
            // 
            // txtCustomerNationality
            // 
            txtCustomerNationality.Location = new Point(125, 363);
            txtCustomerNationality.Name = "txtCustomerNationality";
            txtCustomerNationality.Size = new Size(326, 23);
            txtCustomerNationality.TabIndex = 6;
            // 
            // picCustomerAvatar
            // 
            picCustomerAvatar.Image = (Image)resources.GetObject("picCustomerAvatar.Image");
            picCustomerAvatar.Location = new Point(19, 419);
            picCustomerAvatar.Name = "picCustomerAvatar";
            picCustomerAvatar.Size = new Size(150, 150);
            picCustomerAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picCustomerAvatar.TabIndex = 7;
            picCustomerAvatar.TabStop = false;
            // 
            // btnBrowser
            // 
            btnBrowser.Location = new Point(226, 479);
            btnBrowser.Name = "btnBrowser";
            btnBrowser.Size = new Size(75, 23);
            btnBrowser.TabIndex = 8;
            btnBrowser.Text = "Browser";
            btnBrowser.UseVisualStyleBackColor = true;
            btnBrowser.Click += btnBrowser_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(325, 479);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 8;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // rdbCertify
            // 
            rdbCertify.AutoSize = true;
            rdbCertify.Location = new Point(184, 545);
            rdbCertify.Name = "rdbCertify";
            rdbCertify.Size = new Size(275, 19);
            rdbCertify.TabIndex = 9;
            rdbCertify.TabStop = true;
            rdbCertify.Text = "I certify that the information provided is correct";
            rdbCertify.UseVisualStyleBackColor = true;
            // 
            // btnRegist
            // 
            btnRegist.BackColor = Color.DarkGray;
            btnRegist.FlatAppearance.BorderSize = 0;
            btnRegist.FlatStyle = FlatStyle.Flat;
            btnRegist.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnRegist.Location = new Point(50, 591);
            btnRegist.Name = "btnRegist";
            btnRegist.Size = new Size(400, 30);
            btnRegist.TabIndex = 10;
            btnRegist.Text = "Regist";
            btnRegist.UseVisualStyleBackColor = false;
            btnRegist.Click += btnRegist_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnCancel.Location = new Point(200, 627);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 30);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblClearFields
            // 
            lblClearFields.AutoSize = true;
            lblClearFields.Location = new Point(392, 414);
            lblClearFields.Name = "lblClearFields";
            lblClearFields.Size = new Size(67, 15);
            lblClearFields.TabIndex = 11;
            lblClearFields.Text = "Clear Fields";
            lblClearFields.Click += lblClearFields_Click;
            // 
            // lblLogIn
            // 
            lblLogIn.AutoSize = true;
            lblLogIn.Font = new Font("Consolas", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblLogIn.Location = new Point(438, 642);
            lblLogIn.Name = "lblLogIn";
            lblLogIn.Size = new Size(48, 17);
            lblLogIn.TabIndex = 12;
            lblLogIn.Text = "Login";
            lblLogIn.Click += lblLogIn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 11.25F, FontStyle.Bold);
            label6.Location = new Point(15, 395);
            label6.Name = "label6";
            label6.Size = new Size(104, 18);
            label6.TabIndex = 13;
            label6.Text = "Your Avatar:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(164, 171);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(287, 23);
            txtPassword.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label7.Location = new Point(15, 172);
            label7.Name = "label7";
            label7.Size = new Size(88, 18);
            label7.TabIndex = 4;
            label7.Text = "Password: ";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(111, 133);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(340, 23);
            txtUserName.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label8.Location = new Point(15, 134);
            label8.Name = "label8";
            label8.Size = new Size(88, 18);
            label8.TabIndex = 4;
            label8.Text = "User Name:";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(164, 211);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(286, 23);
            txtConfirmPassword.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label9.Location = new Point(14, 212);
            label9.Name = "label9";
            label9.Size = new Size(144, 18);
            label9.TabIndex = 4;
            label9.Text = "Confirm Password:";
            // 
            // RegistrationAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(500, 680);
            Controls.Add(label6);
            Controls.Add(lblLogIn);
            Controls.Add(lblClearFields);
            Controls.Add(btnCancel);
            Controls.Add(btnRegist);
            Controls.Add(rdbCertify);
            Controls.Add(btnRemove);
            Controls.Add(btnBrowser);
            Controls.Add(picCustomerAvatar);
            Controls.Add(txtCustomerNationality);
            Controls.Add(txtCustomerPassPort);
            Controls.Add(dteBirthday);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(txtUserName);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtCustomerName);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(picLogo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegistrationAccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += RegistrationAccountForm_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCustomerAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picLogo;
        private Label lblTitle;
        private Label label1;
        private TextBox txtCustomerName;
        private Label label2;
        private DateTimePicker dteBirthday;
        private Label label3;
        private Label label4;
        private TextBox txtCustomerPassPort;
        private Label label5;
        private TextBox txtCustomerNationality;
        private PictureBox picCustomerAvatar;
        private Button btnBrowser;
        private Button btnRemove;
        private RadioButton rdbCertify;
        private Button btnRegist;
        private Button btnCancel;
        private Label lblClearFields;
        private Label lblLogIn;
        private Label label6;
        private TextBox txtPassword;
        private Label label7;
        private TextBox txtUserName;
        private Label label8;
        private TextBox txtConfirmPassword;
        private Label label9;
    }
}