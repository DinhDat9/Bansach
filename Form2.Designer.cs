namespace Toco
{
    partial class Form2
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
            this.btn_out = new System.Windows.Forms.Button();
            this.btn_statistic = new System.Windows.Forms.Button();
            this.btn_product = new System.Windows.Forms.Button();
            this.btn_employee = new System.Windows.Forms.Button();
            this.btn_customer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_out
            // 
            this.btn_out.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_out.Location = new System.Drawing.Point(442, 483);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(221, 49);
            this.btn_out.TabIndex = 52;
            this.btn_out.Text = "OUT";
            this.btn_out.UseVisualStyleBackColor = false;
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // btn_statistic
            // 
            this.btn_statistic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_statistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_statistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_statistic.Location = new System.Drawing.Point(174, 340);
            this.btn_statistic.Name = "btn_statistic";
            this.btn_statistic.Size = new System.Drawing.Size(221, 49);
            this.btn_statistic.TabIndex = 51;
            this.btn_statistic.Text = "STATISTIC";
            this.btn_statistic.UseVisualStyleBackColor = false;
            this.btn_statistic.Click += new System.EventHandler(this.btn_statistic_Click);
            // 
            // btn_product
            // 
            this.btn_product.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_product.Location = new System.Drawing.Point(174, 162);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(221, 49);
            this.btn_product.TabIndex = 50;
            this.btn_product.Text = "Product Data";
            this.btn_product.UseVisualStyleBackColor = false;
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // btn_employee
            // 
            this.btn_employee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employee.Location = new System.Drawing.Point(722, 340);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(221, 49);
            this.btn_employee.TabIndex = 49;
            this.btn_employee.Text = "Employee Data";
            this.btn_employee.UseVisualStyleBackColor = false;
            this.btn_employee.Click += new System.EventHandler(this.btn_employee_Click);
            // 
            // btn_customer
            // 
            this.btn_customer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customer.Location = new System.Drawing.Point(722, 162);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Size = new System.Drawing.Size(221, 50);
            this.btn_customer.TabIndex = 48;
            this.btn_customer.Text = "Customer Data";
            this.btn_customer.UseVisualStyleBackColor = false;
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1094, 617);
            this.Controls.Add(this.btn_out);
            this.Controls.Add(this.btn_statistic);
            this.Controls.Add(this.btn_product);
            this.Controls.Add(this.btn_employee);
            this.Controls.Add(this.btn_customer);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form2";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.Button btn_statistic;
        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Button btn_employee;
        private System.Windows.Forms.Button btn_customer;
    }
}