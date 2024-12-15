namespace Toco
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exitEmp = new System.Windows.Forms.Button();
            this.btn_deleEmp = new System.Windows.Forms.Button();
            this.btn_updateEmp = new System.Windows.Forms.Button();
            this.btn_addEmp = new System.Windows.Forms.Button();
            this.txtB_dateEmp = new System.Windows.Forms.TextBox();
            this.txtB_phoneEmp = new System.Windows.Forms.TextBox();
            this.txtB_emailEmp = new System.Windows.Forms.TextBox();
            this.rad_maleEmp = new System.Windows.Forms.RadioButton();
            this.rad_femaEmp = new System.Windows.Forms.RadioButton();
            this.txtB_nameEmployee = new System.Windows.Forms.TextBox();
            this.txtB_idEmployee = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grView_hienthi7 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grView_hienthi7)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 32);
            this.label1.TabIndex = 70;
            this.label1.Text = "Get Employee Data";
            // 
            // btn_exitEmp
            // 
            this.btn_exitEmp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_exitEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exitEmp.Location = new System.Drawing.Point(633, 345);
            this.btn_exitEmp.Name = "btn_exitEmp";
            this.btn_exitEmp.Size = new System.Drawing.Size(90, 32);
            this.btn_exitEmp.TabIndex = 69;
            this.btn_exitEmp.Text = "EXIT";
            this.btn_exitEmp.UseVisualStyleBackColor = false;
            this.btn_exitEmp.Click += new System.EventHandler(this.btn_exitEmp_Click);
            // 
            // btn_deleEmp
            // 
            this.btn_deleEmp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_deleEmp.Location = new System.Drawing.Point(442, 345);
            this.btn_deleEmp.Name = "btn_deleEmp";
            this.btn_deleEmp.Size = new System.Drawing.Size(90, 32);
            this.btn_deleEmp.TabIndex = 68;
            this.btn_deleEmp.Text = "DELETE";
            this.btn_deleEmp.UseVisualStyleBackColor = false;
            this.btn_deleEmp.Click += new System.EventHandler(this.btn_deleEmp_Click);
            // 
            // btn_updateEmp
            // 
            this.btn_updateEmp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_updateEmp.Location = new System.Drawing.Point(242, 345);
            this.btn_updateEmp.Name = "btn_updateEmp";
            this.btn_updateEmp.Size = new System.Drawing.Size(90, 32);
            this.btn_updateEmp.TabIndex = 67;
            this.btn_updateEmp.Text = "UPDATE";
            this.btn_updateEmp.UseVisualStyleBackColor = false;
            this.btn_updateEmp.Click += new System.EventHandler(this.btn_updateEmp_Click);
            // 
            // btn_addEmp
            // 
            this.btn_addEmp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_addEmp.Location = new System.Drawing.Point(88, 345);
            this.btn_addEmp.Name = "btn_addEmp";
            this.btn_addEmp.Size = new System.Drawing.Size(90, 32);
            this.btn_addEmp.TabIndex = 66;
            this.btn_addEmp.Text = "ADD";
            this.btn_addEmp.UseVisualStyleBackColor = false;
            this.btn_addEmp.Click += new System.EventHandler(this.btn_addEmp_Click);
            // 
            // txtB_dateEmp
            // 
            this.txtB_dateEmp.Location = new System.Drawing.Point(543, 131);
            this.txtB_dateEmp.Name = "txtB_dateEmp";
            this.txtB_dateEmp.Size = new System.Drawing.Size(200, 22);
            this.txtB_dateEmp.TabIndex = 65;
            this.txtB_dateEmp.TextChanged += new System.EventHandler(this.txtB_dateEmp_TextChanged);
            // 
            // txtB_phoneEmp
            // 
            this.txtB_phoneEmp.Location = new System.Drawing.Point(543, 199);
            this.txtB_phoneEmp.Name = "txtB_phoneEmp";
            this.txtB_phoneEmp.Size = new System.Drawing.Size(200, 22);
            this.txtB_phoneEmp.TabIndex = 64;
            // 
            // txtB_emailEmp
            // 
            this.txtB_emailEmp.Location = new System.Drawing.Point(543, 275);
            this.txtB_emailEmp.Name = "txtB_emailEmp";
            this.txtB_emailEmp.Size = new System.Drawing.Size(200, 22);
            this.txtB_emailEmp.TabIndex = 63;
            // 
            // rad_maleEmp
            // 
            this.rad_maleEmp.AutoSize = true;
            this.rad_maleEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_maleEmp.Location = new System.Drawing.Point(310, 273);
            this.rad_maleEmp.Name = "rad_maleEmp";
            this.rad_maleEmp.Size = new System.Drawing.Size(76, 24);
            this.rad_maleEmp.TabIndex = 62;
            this.rad_maleEmp.TabStop = true;
            this.rad_maleEmp.Text = "MALE";
            this.rad_maleEmp.UseVisualStyleBackColor = true;
            // 
            // rad_femaEmp
            // 
            this.rad_femaEmp.AutoSize = true;
            this.rad_femaEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_femaEmp.Location = new System.Drawing.Point(170, 273);
            this.rad_femaEmp.Name = "rad_femaEmp";
            this.rad_femaEmp.Size = new System.Drawing.Size(97, 24);
            this.rad_femaEmp.TabIndex = 61;
            this.rad_femaEmp.TabStop = true;
            this.rad_femaEmp.Text = "FEMALE";
            this.rad_femaEmp.UseVisualStyleBackColor = true;
            // 
            // txtB_nameEmployee
            // 
            this.txtB_nameEmployee.Location = new System.Drawing.Point(211, 199);
            this.txtB_nameEmployee.Name = "txtB_nameEmployee";
            this.txtB_nameEmployee.Size = new System.Drawing.Size(175, 22);
            this.txtB_nameEmployee.TabIndex = 60;
            // 
            // txtB_idEmployee
            // 
            this.txtB_idEmployee.Location = new System.Drawing.Point(211, 129);
            this.txtB_idEmployee.Name = "txtB_idEmployee";
            this.txtB_idEmployee.Size = new System.Drawing.Size(175, 22);
            this.txtB_idEmployee.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(449, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 58;
            this.label7.Text = "Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(449, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 57;
            this.label6.Text = "Phone: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(449, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Name Employee:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "ID Employee:";
            // 
            // grView_hienthi7
            // 
            this.grView_hienthi7.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grView_hienthi7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grView_hienthi7.Location = new System.Drawing.Point(69, 394);
            this.grView_hienthi7.Name = "grView_hienthi7";
            this.grView_hienthi7.RowHeadersWidth = 51;
            this.grView_hienthi7.RowTemplate.Height = 24;
            this.grView_hienthi7.Size = new System.Drawing.Size(674, 155);
            this.grView_hienthi7.TabIndex = 52;
            this.grView_hienthi7.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grView_hienthi7_CellClick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(782, 568);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exitEmp);
            this.Controls.Add(this.btn_deleEmp);
            this.Controls.Add(this.btn_updateEmp);
            this.Controls.Add(this.btn_addEmp);
            this.Controls.Add(this.txtB_dateEmp);
            this.Controls.Add(this.txtB_phoneEmp);
            this.Controls.Add(this.txtB_emailEmp);
            this.Controls.Add(this.rad_maleEmp);
            this.Controls.Add(this.rad_femaEmp);
            this.Controls.Add(this.txtB_nameEmployee);
            this.Controls.Add(this.txtB_idEmployee);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grView_hienthi7);
            this.Name = "Form4";
            this.Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)(this.grView_hienthi7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exitEmp;
        private System.Windows.Forms.Button btn_deleEmp;
        private System.Windows.Forms.Button btn_updateEmp;
        private System.Windows.Forms.Button btn_addEmp;
        private System.Windows.Forms.TextBox txtB_dateEmp;
        private System.Windows.Forms.TextBox txtB_phoneEmp;
        private System.Windows.Forms.TextBox txtB_emailEmp;
        private System.Windows.Forms.RadioButton rad_maleEmp;
        private System.Windows.Forms.RadioButton rad_femaEmp;
        private System.Windows.Forms.TextBox txtB_nameEmployee;
        private System.Windows.Forms.TextBox txtB_idEmployee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grView_hienthi7;
    }
}