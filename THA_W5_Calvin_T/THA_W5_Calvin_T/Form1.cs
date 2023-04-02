using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W5_Calvin_T
{
    public partial class Form1 : Form
    {
        
        List<Product> products = new List<Product>();
        List<Category> categorylist = new List<Category>();
        List<char> productlist = new List<char>();
        DataTable dtProduksimpan = new DataTable();
        DataTable dtProdukTampil = new DataTable();
        DataTable dtCategory = new DataTable();
        List<char> productfilter = new List<char>();
        string category = "";
        bool dipilih1 = false;
        bool dipilih2 = false;
        int counterproduct = 1;
        int countermap = 6;
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, string> categoryMap = new Dictionary<string, string>()
        {
            { "C1", "Jas" },
            { "C2", "T-shirt" },
            { "C3", "Rok" },
            { "C4", "Celana" },
            { "C5", "Cawat" }
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGreen;
            categorylist.Add(new Category { categoryID = "C1", categoryName = "Jas" });
            categorylist.Add(new Category { categoryID = "C2", categoryName = "T-shirt" });
            categorylist.Add(new Category { categoryID = "C3", categoryName = "Rok" });
            categorylist.Add(new Category { categoryID = "C4", categoryName = "Celana" });
            categorylist.Add(new Category { categoryID = "C5", categoryName = "Cawat" });

            dtProduksimpan.Columns.Add("Id Product");
            dtProduksimpan.Columns.Add("Nama Product");
            dtProduksimpan.Columns.Add("Harga");
            dtProduksimpan.Columns.Add("Stock");
            dtProduksimpan.Columns.Add("Id category");
            dtProdukTampil.Columns.Add("Id Product");
            dtProdukTampil.Columns.Add("Nama Product");
            dtProdukTampil.Columns.Add("Harga");
            dtProdukTampil.Columns.Add("Stock");
            dtProdukTampil.Columns.Add("Id category");
            dtCategory.Columns.Add("Id category");
            dtCategory.Columns.Add("Nama category");
            dataGridView2.DataSource = dtCategory;
            
            products.Add(new Product { productName = "Jas Hitam", productHarga = "100000", productStock = "10", productcategory = "C1" });
            products.Add(new Product { productName = "T-shirt Black Pink", productHarga = "70000", productStock = "12", productcategory = "C2" });
            products.Add(new Product { productName = "T-Shirt Obsessive", productHarga = "75000", productStock = "16", productcategory = "C2" });
            products.Add(new Product { productName = "Rok mini", productHarga = "82000", productStock = "26", productcategory = "C3" }); 
            products.Add(new Product { productName = "Jeans Biru", productHarga = "90000", productStock = "18", productcategory = "C4" });
            products.Add(new Product { productName = "Celana Pendek Coklat", productHarga = "60000", productStock = "18", productcategory = "C4" });
            products.Add(new Product { productName = "Cawat Blink-blink", productHarga = "1000000", productStock = "1", productcategory = "C5" });
            products.Add(new Product { productName = "Rocca Shirt", productHarga = "50000", productStock = "8", productcategory = "C2" });
            updateCategory();
            foreach (Product product in products)
            {

                AddProduct();
                break;
            }
            
            dataGridView1.DataSource = dtProduksimpan;
            cmbBox_filter.DataSource = dtCategory;
            
            cmbBox_filter.Text = "";
            updateCategorycmbbox();
        }
        private void btn_filter_Click(object sender, EventArgs e)
        {

            cmbBox_filter.Enabled = true;
            updateFilter();
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            cmbBox_filter.Text = "";
            cmbBox_filter.Enabled = false;
            dataGridView1.DataSource = dtProduksimpan;
            productfilter.Clear();
        }

        private void cmbBox_Category_SelectionChangeCommitted(object sender, EventArgs e)
        {
            category = "C" + (cmbBox_Category.SelectedIndex + 1);
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbox_NamaProduct.Text) && cmbBox_Category.Text == "" && string.IsNullOrEmpty(tbox_harga.Text) && string.IsNullOrEmpty(tbox_stock.Text))
            {
                MessageBox.Show("All fields must be filled", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                products.Add(new Product
                {
                    productName = tbox_NamaProduct.Text,
                    productHarga = tbox_harga.Text,
                    productStock = tbox_stock.Text,
                    productcategory = category
                });
                AddProduct();

            }

        }

        private void btn_addCaterogry_Click(object sender, EventArgs e)
        {
            bool ada = false;
            if(tbox_NamaCategory.Text == "")
            {
                MessageBox.Show("All fields must be filled", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach(Category a in categorylist)
                {
                    if (a.categoryName.ToUpper().Contains(tbox_NamaCategory.Text.ToUpper()))
                    {
                        ada = true;
                        break;
                    }
                }
                if(ada == true)
                {
                    MessageBox.Show("Category already exist","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    categorylist.Add(new Category { categoryID = "C" + countermap, categoryName = tbox_NamaCategory.Text }); ;
                    categoryMap.Add("C" + countermap, tbox_NamaCategory.Text);
                    countermap++;
                    updateCategory();
                    updateCategorycmbbox();
                    updateFilter();
                }
                
            }
        }
        private void btn_removeCategory_Click(object sender, EventArgs e)
        {
            if (dipilih2 == false)
            {
                MessageBox.Show("Choose a cell in Category Grid", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<Product> removedProduct = new List<Product>();
                DataGridViewRow row = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex];
                string nama = row.Cells["Id category"].Value.ToString();
                foreach (Product product in products)
                {
                    if (product.productcategory.Contains(nama))
                    {
                        removedProduct.Add(product);
                    }

                }
                foreach (Product product in removedProduct)
                {
                    products.Remove(product);
                }
                categorylist.RemoveAt(dataGridView2.CurrentCell.RowIndex);
                updateCategory();
                updateCategorycmbbox();
                AddProduct();
                updateFilter();
                tbox_NamaCategory.Clear();
                removedProduct.Clear();
            }
            
        }
        private void cmbBox_filter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            filterproduct();
            dataGridView1.DataSource = dtProdukTampil;

        }
        private void btn_editProduct_Click(object sender, EventArgs e)
        {
            if(dipilih1 == false)
            {
                MessageBox.Show("Choose a cell in Product Grid", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (tbox_harga.Text == "" || tbox_NamaProduct.Text == "" || cmbBox_Category.Text == "" || tbox_stock.Text == "")
                {
                    MessageBox.Show("All fields must be filled", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataGridViewRow row = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
                    string nama = row.Cells["Nama Product"].Value.ToString();
                    string newcategory = "";

                    for (int i = 0; i < products.Count; i++)
                    {
                        if (products[i].productName == nama)
                        {
                            foreach (Category a in categorylist)
                            {
                                if (a.categoryName == cmbBox_Category.Text)
                                {
                                    newcategory = a.categoryID;
                                }
                            }
                            if (Convert.ToInt32(tbox_stock.Text) <= 0)
                            {
                                products.RemoveAt(i);
                            }
                            else
                            {
                                products[i].productName = tbox_NamaProduct.Text;
                                products[i].productHarga = tbox_harga.Text;
                                products[i].productStock = tbox_stock.Text;
                                products[i].productcategory = newcategory;
                            }

                        }
                    }
                    AddProduct();
                    tbox_NamaProduct.Clear();
                    tbox_harga.Clear();
                    tbox_stock.Clear();
                    cmbBox_Category.SelectedIndex = -1;
                    dipilih1 = false;
                }
            }
        }
        private void btn_removeProduct_Click(object sender, EventArgs e)
        {
            if (dipilih1 == false)
            {
                MessageBox.Show("Choose a cell in Product Grid", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataGridViewRow row = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
                string nama = row.Cells["Nama Product"].Value.ToString();
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].productName == nama)
                    {
                        products.RemoveAt(i);
                        break;
                    }
                }
                AddProduct();
                tbox_NamaProduct.Clear();
                tbox_harga.Clear();
                tbox_stock.Clear();
                cmbBox_Category.SelectedIndex = -1;
                dipilih1 = false;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Grid1Click();
            dipilih1 = true;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Grid2Click();
            dipilih2 = true;
        }
        //clicking grid 1
        public void Grid1Click()
        {
            if (dataGridView1.CurrentCell.RowIndex >= 0)
            {
                
                    DataGridViewRow row = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
                    tbox_NamaProduct.Text = row.Cells["Nama Product"].Value.ToString();
                    tbox_harga.Text = row.Cells["Harga"].Value.ToString();
                    tbox_stock.Text = row.Cells["Stock"].Value.ToString();
                    string code = row.Cells["Id category"].Value.ToString();
                    string nama = categoryMap[code];
                    cmbBox_Category.Text = nama;
            }
        }
        //clicking grid 2
        public void Grid2Click()
        {
            if (dataGridView2.CurrentCell.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex];
                tbox_NamaCategory.Text = row.Cells["Nama category"].Value.ToString();
            }
        }
        //add product to dgv
        public void AddProduct()
        {
            dtProduksimpan.Clear();
            productlist.Clear();
            foreach (Product product in products)
            {
                string huruf = product.productName;
                char[] huruf1 = huruf.ToCharArray();

                if (productlist.Contains(huruf1[0]))
                {

                    if (counterproduct < 10)
                    {
                        dtProduksimpan.Rows.Add(huruf1[0].ToString().ToUpper() + "00" + counterproduct, product.productName, product.productHarga, product.productStock, product.productcategory);
                        counterproduct++;
                    }
                    else if (counterproduct > 10 && counterproduct < 100)
                    {
                        dtProduksimpan.Rows.Add(huruf1[0].ToString().ToUpper() + "0" + counterproduct, product.productName, product.productHarga, product.productStock, product.productcategory);
                        counterproduct++;
                    }
                    else if (counterproduct >= 100)
                    {
                        dtProduksimpan.Rows.Add(huruf1[0].ToString().ToUpper() + counterproduct, product.productName, product.productHarga, product.productStock, product.productcategory);
                        counterproduct++;
                    }
                }
                else
                {
                    counterproduct = 1;
                    productlist.Add(huruf1[0]);
                    dtProduksimpan.Rows.Add(huruf1[0].ToString().ToUpper() + "00" + counterproduct, product.productName, product.productHarga, product.productStock, product.productcategory);
                    counterproduct++;
                }



            }

        }
        //add filter product to dgv
        public void filterproduct()
        {
            dtProdukTampil.Clear();

            foreach (Product product in products)
            {
                if (cmbBox_filter.SelectedValue.ToString() == product.productcategory)
                {
                    string huruf = product.productName;
                    char[] huruf1 = huruf.ToCharArray();

                    if (productfilter.Contains(huruf1[0]))
                    {
                        if (counterproduct < 10)
                        {
                            dtProdukTampil.Rows.Add(huruf1[0].ToString().ToUpper() + "00" + counterproduct, product.productName, product.productHarga, product.productStock, product.productcategory);
                            counterproduct++;
                        }
                        else if (counterproduct > 10 && counterproduct < 100)
                        {
                            dtProdukTampil.Rows.Add(huruf1[0].ToString().ToUpper() + "0" + counterproduct, product.productName, product.productHarga, product.productStock, product.productcategory);
                            counterproduct++;
                        }
                        else if (counterproduct >= 100)
                        {
                            dtProdukTampil.Rows.Add(huruf1[0].ToString().ToUpper() + counterproduct, product.productName, product.productHarga, product.productStock, product.productcategory);
                            counterproduct++;
                        }

                    }
                    else
                    {
                        counterproduct = 1;
                        productfilter.Add(huruf1[0]);
                        dtProdukTampil.Rows.Add(huruf1[0].ToString().ToUpper() + "00" + counterproduct, product.productName, product.productHarga, product.productStock, product.productcategory);
                        counterproduct++;
                    }
                }

            }
        }
        //add category to dgv
        public void updateCategory()
        {
            dtCategory.Clear();
            foreach (Category a in categorylist)
            {
                dtCategory.Rows.Add(a.categoryID, a.categoryName);

            }
        }
        //updating filter combo box
        public void updateFilter()
        {
            cmbBox_filter.DisplayMember = "Nama category";
            cmbBox_filter.ValueMember = "Id category";
            cmbBox_filter.Text = "";
        }
        //updating category combo box
        public void updateCategorycmbbox()
        {
            cmbBox_Category.Items.Clear();
            foreach (Category a in categorylist)
            {
                cmbBox_Category.Items.Add(a.categoryName);
            }
        }
        private void tbox_harga_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
        private void tbox_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;

        }

       
    }
}
