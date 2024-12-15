namespace Toco
{
    partial class Form5
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
            this.txtB_inputPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtB_inventProduct = new System.Windows.Forms.TextBox();
            this.cbB_sizeProduct = new System.Windows.Forms.ComboBox();
            this.txtB_priceProduct = new System.Windows.Forms.TextBox();
            this.txtB_nameProduct = new System.Windows.Forms.TextBox();
            this.txtB_idProduct = new System.Windows.Forms.TextBox();
            this.btn_deleProduct = new System.Windows.Forms.Button();
            this.btn_updProduct = new System.Windows.Forms.Button();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.picB_imageProduct = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB_search = new System.Windows.Forms.TextBox();
            this.GridV_hienthi6 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picB_imageProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridV_hienthi6)).BeginInit();
            this.SuspendLayout();
            // 
            // txtB_inputPrice
            // 
            this.txtB_inputPrice.Location = new System.Drawing.Point(824, 350);
            this.txtB_inputPrice.Multiline = true;
            this.txtB_inputPrice.Name = "txtB_inputPrice";
            this.txtB_inputPrice.Size = new System.Drawing.Size(152, 22);
            this.txtB_inputPrice.TabIndex = 74;
            this.txtB_inputPrice.TextChanged += new System.EventHandler(this.txtB_inputPrice_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(684, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 73;
            this.label3.Text = "InputPrice:";
            // 
            // txtB_inventProduct
            // 
            this.txtB_inventProduct.Location = new System.Drawing.Point(824, 407);
            this.txtB_inventProduct.Multiline = true;
            this.txtB_inventProduct.Name = "txtB_inventProduct";
            this.txtB_inventProduct.Size = new System.Drawing.Size(152, 24);
            this.txtB_inventProduct.TabIndex = 72;
            // 
            // cbB_sizeProduct
            // 
            this.cbB_sizeProduct.FormattingEnabled = true;
            this.cbB_sizeProduct.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL",
            "XXL"});
            this.cbB_sizeProduct.Location = new System.Drawing.Point(824, 282);
            this.cbB_sizeProduct.Name = "cbB_sizeProduct";
            this.cbB_sizeProduct.Size = new System.Drawing.Size(152, 24);
            this.cbB_sizeProduct.TabIndex = 71;
            this.cbB_sizeProduct.SelectedIndexChanged += new System.EventHandler(this.cbB_sizeProduct_SelectedIndexChanged);
            // 
            // txtB_priceProduct
            // 
            this.txtB_priceProduct.Location = new System.Drawing.Point(824, 476);
            this.txtB_priceProduct.Multiline = true;
            this.txtB_priceProduct.Name = "txtB_priceProduct";
            this.txtB_priceProduct.Size = new System.Drawing.Size(149, 22);
            this.txtB_priceProduct.TabIndex = 70;
            // 
            // txtB_nameProduct
            // 
            this.txtB_nameProduct.Location = new System.Drawing.Point(824, 172);
            this.txtB_nameProduct.Multiline = true;
            this.txtB_nameProduct.Name = "txtB_nameProduct";
            this.txtB_nameProduct.Size = new System.Drawing.Size(149, 22);
            this.txtB_nameProduct.TabIndex = 69;
            // 
            // txtB_idProduct
            // 
            this.txtB_idProduct.Location = new System.Drawing.Point(824, 224);
            this.txtB_idProduct.Multiline = true;
            this.txtB_idProduct.Name = "txtB_idProduct";
            this.txtB_idProduct.Size = new System.Drawing.Size(149, 22);
            this.txtB_idProduct.TabIndex = 68;
            // 
            // btn_deleProduct
            // 
            this.btn_deleProduct.Location = new System.Drawing.Point(913, 516);
            this.btn_deleProduct.Name = "btn_deleProduct";
            this.btn_deleProduct.Size = new System.Drawing.Size(75, 28);
            this.btn_deleProduct.TabIndex = 67;
            this.btn_deleProduct.Text = "DELETE";
            this.btn_deleProduct.UseVisualStyleBackColor = true;
            this.btn_deleProduct.Click += new System.EventHandler(this.btn_deleProduct_Click);
            // 
            // btn_updProduct
            // 
            this.btn_updProduct.Location = new System.Drawing.Point(805, 516);
            this.btn_updProduct.Name = "btn_updProduct";
            this.btn_updProduct.Size = new System.Drawing.Size(73, 28);
            this.btn_updProduct.TabIndex = 66;
            this.btn_updProduct.Text = "UPDATE";
            this.btn_updProduct.UseVisualStyleBackColor = true;
            this.btn_updProduct.Click += new System.EventHandler(this.btn_updProduct_Click);
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Location = new System.Drawing.Point(688, 516);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(75, 28);
            this.btn_addProduct.TabIndex = 65;
            this.btn_addProduct.Text = "ADD";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(691, 421);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(88, 22);
            this.label22.TabIndex = 64;
            this.label22.Text = "Inventory:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(684, 474);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(110, 22);
            this.label21.TabIndex = 63;
            this.label21.Text = "SellingPrice:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(684, 284);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(116, 22);
            this.label20.TabIndex = 62;
            this.label20.Text = "Size Product:";
            // 
            // picB_imageProduct
            // 
            this.picB_imageProduct.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picB_imageProduct.Location = new System.Drawing.Point(734, 7);
            this.picB_imageProduct.Name = "picB_imageProduct";
            this.picB_imageProduct.Size = new System.Drawing.Size(239, 149);
            this.picB_imageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picB_imageProduct.TabIndex = 61;
            this.picB_imageProduct.TabStop = false;
            this.picB_imageProduct.Click += new System.EventHandler(this.picB_imageProduct_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(684, 172);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(129, 22);
            this.label19.TabIndex = 60;
            this.label19.Text = "Name Product:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(684, 224);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 22);
            this.label18.TabIndex = 59;
            this.label18.Text = "ID Product:";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_search.Location = new System.Drawing.Point(607, 129);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(92, 27);
            this.btn_search.TabIndex = 57;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 56;
            this.label2.Text = "Search:";
            // 
            // txtB_search
            // 
            this.txtB_search.Location = new System.Drawing.Point(144, 129);
            this.txtB_search.Multiline = true;
            this.txtB_search.Name = "txtB_search";
            this.txtB_search.Size = new System.Drawing.Size(412, 22);
            this.txtB_search.TabIndex = 55;
            // 
            // GridV_hienthi6
            // 
            this.GridV_hienthi6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridV_hienthi6.Location = new System.Drawing.Point(54, 162);
            this.GridV_hienthi6.Name = "GridV_hienthi6";
            this.GridV_hienthi6.RowHeadersWidth = 51;
            this.GridV_hienthi6.RowTemplate.Height = 24;
            this.GridV_hienthi6.Size = new System.Drawing.Size(593, 382);
            this.GridV_hienthi6.TabIndex = 54;
            this.GridV_hienthi6.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridV_hienthi6_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 32);
            this.label1.TabIndex = 53;
            this.label1.Text = "Get Product Data";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1038, 570);
            this.Controls.Add(this.txtB_inputPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtB_inventProduct);
            this.Controls.Add(this.cbB_sizeProduct);
            this.Controls.Add(this.txtB_priceProduct);
            this.Controls.Add(this.txtB_nameProduct);
            this.Controls.Add(this.txtB_idProduct);
            this.Controls.Add(this.btn_deleProduct);
            this.Controls.Add(this.btn_updProduct);
            this.Controls.Add(this.btn_addProduct);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.picB_imageProduct);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtB_search);
            this.Controls.Add(this.GridV_hienthi6);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Product Data";
            this.Load += new System.EventHandler(this.Form5_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.picB_imageProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridV_hienthi6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtB_inputPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtB_inventProduct;
        private System.Windows.Forms.ComboBox cbB_sizeProduct;
        private System.Windows.Forms.TextBox txtB_priceProduct;
        private System.Windows.Forms.TextBox txtB_nameProduct;
        private System.Windows.Forms.TextBox txtB_idProduct;
        private System.Windows.Forms.Button btn_deleProduct;
        private System.Windows.Forms.Button btn_updProduct;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox picB_imageProduct;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB_search;
        private System.Windows.Forms.DataGridView GridV_hienthi6;
        private System.Windows.Forms.Label label1;
    }
}