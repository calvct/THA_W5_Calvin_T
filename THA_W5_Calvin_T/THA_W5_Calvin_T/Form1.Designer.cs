namespace THA_W5_Calvin_T
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbox_NamaProduct = new System.Windows.Forms.TextBox();
            this.tbox_harga = new System.Windows.Forms.TextBox();
            this.tbox_stock = new System.Windows.Forms.TextBox();
            this.tbox_NamaCategory = new System.Windows.Forms.TextBox();
            this.cmbBox_Category = new System.Windows.Forms.ComboBox();
            this.cmbBox_filter = new System.Windows.Forms.ComboBox();
            this.btn_filter = new System.Windows.Forms.Button();
            this.btn_all = new System.Windows.Forms.Button();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.btn_editProduct = new System.Windows.Forms.Button();
            this.btn_removeProduct = new System.Windows.Forms.Button();
            this.btn_addCaterogry = new System.Windows.Forms.Button();
            this.btn_removeCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(33, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(370, 220);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(442, 79);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(207, 182);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nama:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Catergory:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Harga:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Stock:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(439, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nama:";
            // 
            // tbox_NamaProduct
            // 
            this.tbox_NamaProduct.Location = new System.Drawing.Point(74, 342);
            this.tbox_NamaProduct.Name = "tbox_NamaProduct";
            this.tbox_NamaProduct.Size = new System.Drawing.Size(328, 20);
            this.tbox_NamaProduct.TabIndex = 10;
            // 
            // tbox_harga
            // 
            this.tbox_harga.Location = new System.Drawing.Point(75, 392);
            this.tbox_harga.Name = "tbox_harga";
            this.tbox_harga.Size = new System.Drawing.Size(98, 20);
            this.tbox_harga.TabIndex = 11;
            this.tbox_harga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_harga_KeyPress);
            // 
            // tbox_stock
            // 
            this.tbox_stock.Location = new System.Drawing.Point(75, 417);
            this.tbox_stock.Name = "tbox_stock";
            this.tbox_stock.Size = new System.Drawing.Size(98, 20);
            this.tbox_stock.TabIndex = 12;
            this.tbox_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_stock_KeyPress);
            // 
            // tbox_NamaCategory
            // 
            this.tbox_NamaCategory.Location = new System.Drawing.Point(495, 272);
            this.tbox_NamaCategory.Name = "tbox_NamaCategory";
            this.tbox_NamaCategory.Size = new System.Drawing.Size(154, 20);
            this.tbox_NamaCategory.TabIndex = 13;
            // 
            // cmbBox_Category
            // 
            this.cmbBox_Category.FormattingEnabled = true;
            this.cmbBox_Category.Location = new System.Drawing.Point(75, 366);
            this.cmbBox_Category.Name = "cmbBox_Category";
            this.cmbBox_Category.Size = new System.Drawing.Size(121, 21);
            this.cmbBox_Category.TabIndex = 14;
            this.cmbBox_Category.SelectionChangeCommitted += new System.EventHandler(this.cmbBox_Category_SelectionChangeCommitted);
            // 
            // cmbBox_filter
            // 
            this.cmbBox_filter.Enabled = false;
            this.cmbBox_filter.FormattingEnabled = true;
            this.cmbBox_filter.Location = new System.Drawing.Point(309, 52);
            this.cmbBox_filter.Name = "cmbBox_filter";
            this.cmbBox_filter.Size = new System.Drawing.Size(94, 21);
            this.cmbBox_filter.TabIndex = 15;
            this.cmbBox_filter.SelectionChangeCommitted += new System.EventHandler(this.cmbBox_filter_SelectionChangeCommitted);
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(253, 52);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(50, 20);
            this.btn_filter.TabIndex = 16;
            this.btn_filter.Text = "filter";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // btn_all
            // 
            this.btn_all.Location = new System.Drawing.Point(197, 53);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(50, 20);
            this.btn_all.TabIndex = 17;
            this.btn_all.Text = "all";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Location = new System.Drawing.Point(197, 398);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(64, 42);
            this.btn_addProduct.TabIndex = 18;
            this.btn_addProduct.Text = "Add product";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // btn_editProduct
            // 
            this.btn_editProduct.Location = new System.Drawing.Point(267, 398);
            this.btn_editProduct.Name = "btn_editProduct";
            this.btn_editProduct.Size = new System.Drawing.Size(64, 42);
            this.btn_editProduct.TabIndex = 19;
            this.btn_editProduct.Text = "Edit product";
            this.btn_editProduct.UseVisualStyleBackColor = true;
            this.btn_editProduct.Click += new System.EventHandler(this.btn_editProduct_Click);
            // 
            // btn_removeProduct
            // 
            this.btn_removeProduct.Location = new System.Drawing.Point(335, 398);
            this.btn_removeProduct.Name = "btn_removeProduct";
            this.btn_removeProduct.Size = new System.Drawing.Size(64, 42);
            this.btn_removeProduct.TabIndex = 20;
            this.btn_removeProduct.Text = "Remove product";
            this.btn_removeProduct.UseVisualStyleBackColor = true;
            this.btn_removeProduct.Click += new System.EventHandler(this.btn_removeProduct_Click);
            // 
            // btn_addCaterogry
            // 
            this.btn_addCaterogry.Location = new System.Drawing.Point(515, 302);
            this.btn_addCaterogry.Name = "btn_addCaterogry";
            this.btn_addCaterogry.Size = new System.Drawing.Size(64, 42);
            this.btn_addCaterogry.TabIndex = 21;
            this.btn_addCaterogry.Text = "Add Category";
            this.btn_addCaterogry.UseVisualStyleBackColor = true;
            this.btn_addCaterogry.Click += new System.EventHandler(this.btn_addCaterogry_Click);
            // 
            // btn_removeCategory
            // 
            this.btn_removeCategory.Location = new System.Drawing.Point(585, 302);
            this.btn_removeCategory.Name = "btn_removeCategory";
            this.btn_removeCategory.Size = new System.Drawing.Size(64, 42);
            this.btn_removeCategory.TabIndex = 22;
            this.btn_removeCategory.Text = "Remove Category";
            this.btn_removeCategory.UseVisualStyleBackColor = true;
            this.btn_removeCategory.Click += new System.EventHandler(this.btn_removeCategory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 528);
            this.Controls.Add(this.btn_removeCategory);
            this.Controls.Add(this.btn_addCaterogry);
            this.Controls.Add(this.btn_removeProduct);
            this.Controls.Add(this.btn_editProduct);
            this.Controls.Add(this.btn_addProduct);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.cmbBox_filter);
            this.Controls.Add(this.cmbBox_Category);
            this.Controls.Add(this.tbox_NamaCategory);
            this.Controls.Add(this.tbox_stock);
            this.Controls.Add(this.tbox_harga);
            this.Controls.Add(this.tbox_NamaProduct);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbox_NamaProduct;
        private System.Windows.Forms.TextBox tbox_harga;
        private System.Windows.Forms.TextBox tbox_stock;
        private System.Windows.Forms.TextBox tbox_NamaCategory;
        private System.Windows.Forms.ComboBox cmbBox_Category;
        private System.Windows.Forms.ComboBox cmbBox_filter;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.Button btn_all;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Button btn_editProduct;
        private System.Windows.Forms.Button btn_removeProduct;
        private System.Windows.Forms.Button btn_addCaterogry;
        private System.Windows.Forms.Button btn_removeCategory;
    }
}

