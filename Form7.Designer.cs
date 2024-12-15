namespace Toco
{
    partial class Form7
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
            this.txtB_TotalBaseCost = new System.Windows.Forms.TextBox();
            this.TotalBaseCost = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtB_Profit = new System.Windows.Forms.TextBox();
            this.txtB_TotalCost = new System.Windows.Forms.TextBox();
            this.txtB_TotalRevenue = new System.Windows.Forms.TextBox();
            this.btn_dele = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dGv_Statistic = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dTP_end = new System.Windows.Forms.DateTimePicker();
            this.dTP_start = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGv_Statistic)).BeginInit();
            this.SuspendLayout();
            // 
            // txtB_TotalBaseCost
            // 
            this.txtB_TotalBaseCost.Location = new System.Drawing.Point(580, 340);
            this.txtB_TotalBaseCost.Multiline = true;
            this.txtB_TotalBaseCost.Name = "txtB_TotalBaseCost";
            this.txtB_TotalBaseCost.ReadOnly = true;
            this.txtB_TotalBaseCost.Size = new System.Drawing.Size(212, 22);
            this.txtB_TotalBaseCost.TabIndex = 84;
            // 
            // TotalBaseCost
            // 
            this.TotalBaseCost.AutoSize = true;
            this.TotalBaseCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBaseCost.Location = new System.Drawing.Point(446, 342);
            this.TotalBaseCost.Name = "TotalBaseCost";
            this.TotalBaseCost.Size = new System.Drawing.Size(125, 20);
            this.TotalBaseCost.TabIndex = 83;
            this.TotalBaseCost.Text = "TotalBaseCost:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(458, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 82;
            this.label7.Text = "Profit:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(446, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 81;
            this.label6.Text = "TotalCost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(446, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 80;
            this.label5.Text = "TotalRevenue:";
            // 
            // txtB_Profit
            // 
            this.txtB_Profit.Location = new System.Drawing.Point(580, 383);
            this.txtB_Profit.Multiline = true;
            this.txtB_Profit.Name = "txtB_Profit";
            this.txtB_Profit.ReadOnly = true;
            this.txtB_Profit.Size = new System.Drawing.Size(212, 22);
            this.txtB_Profit.TabIndex = 79;
            // 
            // txtB_TotalCost
            // 
            this.txtB_TotalCost.Location = new System.Drawing.Point(580, 294);
            this.txtB_TotalCost.Multiline = true;
            this.txtB_TotalCost.Name = "txtB_TotalCost";
            this.txtB_TotalCost.ReadOnly = true;
            this.txtB_TotalCost.Size = new System.Drawing.Size(212, 22);
            this.txtB_TotalCost.TabIndex = 78;
            // 
            // txtB_TotalRevenue
            // 
            this.txtB_TotalRevenue.Location = new System.Drawing.Point(580, 256);
            this.txtB_TotalRevenue.Multiline = true;
            this.txtB_TotalRevenue.Name = "txtB_TotalRevenue";
            this.txtB_TotalRevenue.ReadOnly = true;
            this.txtB_TotalRevenue.Size = new System.Drawing.Size(212, 22);
            this.txtB_TotalRevenue.TabIndex = 77;
            // 
            // btn_dele
            // 
            this.btn_dele.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dele.Location = new System.Drawing.Point(658, 431);
            this.btn_dele.Name = "btn_dele";
            this.btn_dele.Size = new System.Drawing.Size(134, 42);
            this.btn_dele.TabIndex = 76;
            this.btn_dele.Text = "DELETE:";
            this.btn_dele.UseVisualStyleBackColor = true;
            this.btn_dele.Click += new System.EventHandler(this.btn_dele_Click);
            // 
            // btn_load
            // 
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(462, 431);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(128, 42);
            this.btn_load.TabIndex = 75;
            this.btn_load.Text = "LOAD STATISTIC:";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 74;
            this.label4.Text = "STATISTIC:";
            // 
            // dGv_Statistic
            // 
            this.dGv_Statistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGv_Statistic.Location = new System.Drawing.Point(33, 194);
            this.dGv_Statistic.Name = "dGv_Statistic";
            this.dGv_Statistic.ReadOnly = true;
            this.dGv_Statistic.RowHeadersWidth = 51;
            this.dGv_Statistic.RowTemplate.Height = 24;
            this.dGv_Statistic.Size = new System.Drawing.Size(407, 279);
            this.dGv_Statistic.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(488, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 72;
            this.label3.Text = "END:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(488, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 71;
            this.label2.Text = "START:";
            // 
            // dTP_end
            // 
            this.dTP_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_end.Location = new System.Drawing.Point(653, 217);
            this.dTP_end.Name = "dTP_end";
            this.dTP_end.Size = new System.Drawing.Size(139, 22);
            this.dTP_end.TabIndex = 70;
            // 
            // dTP_start
            // 
            this.dTP_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_start.Location = new System.Drawing.Point(653, 177);
            this.dTP_start.Name = "dTP_start";
            this.dTP_start.Size = new System.Drawing.Size(133, 22);
            this.dTP_start.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 68;
            this.label1.Text = "STATISTIC";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(809, 488);
            this.Controls.Add(this.txtB_TotalBaseCost);
            this.Controls.Add(this.TotalBaseCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtB_Profit);
            this.Controls.Add(this.txtB_TotalCost);
            this.Controls.Add(this.txtB_TotalRevenue);
            this.Controls.Add(this.btn_dele);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dGv_Statistic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dTP_end);
            this.Controls.Add(this.dTP_start);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form7";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.dGv_Statistic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtB_TotalBaseCost;
        private System.Windows.Forms.Label TotalBaseCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtB_Profit;
        private System.Windows.Forms.TextBox txtB_TotalCost;
        private System.Windows.Forms.TextBox txtB_TotalRevenue;
        private System.Windows.Forms.Button btn_dele;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dGv_Statistic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dTP_end;
        private System.Windows.Forms.DateTimePicker dTP_start;
        private System.Windows.Forms.Label label1;
    }
}