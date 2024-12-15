namespace Toco
{
    partial class Form0
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
            this.btn_accept = new System.Windows.Forms.Button();
            this.txtB_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtB_Phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_BirthofDate = new System.Windows.Forms.DateTimePicker();
            this.rad_male = new System.Windows.Forms.RadioButton();
            this.rad_female = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtB_CustomerName = new System.Windows.Forms.TextBox();
            this.txtB_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB_UserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_accept
            // 
            this.btn_accept.BackColor = System.Drawing.Color.Tomato;
            this.btn_accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accept.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_accept.Location = new System.Drawing.Point(569, 608);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(118, 68);
            this.btn_accept.TabIndex = 36;
            this.btn_accept.Text = "Accept";
            this.btn_accept.UseVisualStyleBackColor = false;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // txtB_email
            // 
            this.txtB_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_email.Location = new System.Drawing.Point(340, 657);
            this.txtB_email.Multiline = true;
            this.txtB_email.Name = "txtB_email";
            this.txtB_email.Size = new System.Drawing.Size(171, 22);
            this.txtB_email.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(216, 656);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Email:";
            // 
            // txtB_Phone
            // 
            this.txtB_Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_Phone.Location = new System.Drawing.Point(342, 612);
            this.txtB_Phone.Multiline = true;
            this.txtB_Phone.Name = "txtB_Phone";
            this.txtB_Phone.Size = new System.Drawing.Size(169, 22);
            this.txtB_Phone.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(211, 614);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(200, 566);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "DateOfBirth:";
            // 
            // dtp_BirthofDate
            // 
            this.dtp_BirthofDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_BirthofDate.Location = new System.Drawing.Point(340, 566);
            this.dtp_BirthofDate.Name = "dtp_BirthofDate";
            this.dtp_BirthofDate.Size = new System.Drawing.Size(171, 22);
            this.dtp_BirthofDate.TabIndex = 32;
            // 
            // rad_male
            // 
            this.rad_male.AutoSize = true;
            this.rad_male.Location = new System.Drawing.Point(218, 21);
            this.rad_male.Name = "rad_male";
            this.rad_male.Size = new System.Drawing.Size(68, 20);
            this.rad_male.TabIndex = 31;
            this.rad_male.TabStop = true;
            this.rad_male.Text = "MALE";
            this.rad_male.UseVisualStyleBackColor = true;
            // 
            // rad_female
            // 
            this.rad_female.AutoSize = true;
            this.rad_female.Location = new System.Drawing.Point(98, 21);
            this.rad_female.Name = "rad_female";
            this.rad_female.Size = new System.Drawing.Size(87, 20);
            this.rad_female.TabIndex = 29;
            this.rad_female.TabStop = true;
            this.rad_female.Text = "FEMALE";
            this.rad_female.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "NameCustomer:";
            // 
            // txtB_CustomerName
            // 
            this.txtB_CustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_CustomerName.Location = new System.Drawing.Point(340, 440);
            this.txtB_CustomerName.Multiline = true;
            this.txtB_CustomerName.Name = "txtB_CustomerName";
            this.txtB_CustomerName.Size = new System.Drawing.Size(171, 22);
            this.txtB_CustomerName.TabIndex = 27;
            this.txtB_CustomerName.TextChanged += new System.EventHandler(this.txtB_CustomerName_TextChanged);
            // 
            // txtB_Password
            // 
            this.txtB_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_Password.Location = new System.Drawing.Point(340, 385);
            this.txtB_Password.Multiline = true;
            this.txtB_Password.Name = "txtB_Password";
            this.txtB_Password.PasswordChar = '*';
            this.txtB_Password.Size = new System.Drawing.Size(171, 22);
            this.txtB_Password.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Password:";
            // 
            // txtB_UserName
            // 
            this.txtB_UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_UserName.Location = new System.Drawing.Point(340, 333);
            this.txtB_UserName.Multiline = true;
            this.txtB_UserName.Name = "txtB_UserName";
            this.txtB_UserName.Size = new System.Drawing.Size(171, 22);
            this.txtB_UserName.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "UserName:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Toco.Properties.Resources._53326186ee07de89b7bd928961cdab61;
            this.pictureBox1.Location = new System.Drawing.Point(204, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_female);
            this.groupBox1.Controls.Add(this.rad_male);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(204, 491);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 57);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(709, 711);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.txtB_email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtB_Phone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_BirthofDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtB_CustomerName);
            this.Controls.Add(this.txtB_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtB_UserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form0";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.TextBox txtB_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtB_Phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_BirthofDate;
        private System.Windows.Forms.RadioButton rad_male;
        private System.Windows.Forms.RadioButton rad_female;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtB_CustomerName;
        private System.Windows.Forms.TextBox txtB_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB_UserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}