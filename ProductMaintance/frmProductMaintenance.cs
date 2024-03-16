using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;
//using ProductMaintenance.Models;
//using ProductMaintenance.Models.DataLayer;

namespace ProductMaintenance
{
    public partial class frmProductMaintenance : Form
    {
        
        List<Product> productsInStock = new List<Product>();    
        public frmProductMaintenance()
        {
            loadDataToList();
            InitializeComponent();

        }

        private void loadDataToList()
        {
            Product p0 = new Product("A123", "Red Pens", 100, 1);
            Product p1 = new Product("A124", "Blue Pens", 10, 6);
            Product p2 = new Product("A125", "Green Pens", 900, 7);
            Product p3 = new Product("A126", "Pink Pens", 1000, 2);
            this.productsInStock.Add(p0);
            this.productsInStock.Add(p1);
            this.productsInStock.Add(p2);
            this.productsInStock.Add(p3);
           


        }
        private Product selectedProduct;

        private void frmProductMaintenance_Load(object sender, EventArgs e)
        {
            DisplayProducts();
        }

        private void DisplayProducts ()
        {
            dgvProducts.Columns.Clear();
            dgvProducts.DataSource = new BindingList<Product>(this.productsInStock.ToList());

            // add column for modify button
            var modifyColumn = new DataGridViewButtonColumn() { 
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Modify"
            };
            dgvProducts.Columns.Add(modifyColumn);

            // add column for delete button
            var deleteColumn = new DataGridViewButtonColumn() {
                UseColumnTextForButtonValue = true, 
                HeaderText = "",
                Text = "Delete"
            };
            dgvProducts.Columns.Add(deleteColumn);

            // format the column header
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.Goldenrod;
            dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // format the odd numbered rows
            dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGoldenrod;

            // format the first column
            dgvProducts.Columns[0].HeaderText = "Product Code";
            dgvProducts.Columns[0].Width = 110;

            // format the second column
            dgvProducts.Columns[1].Width = 240;

            // format the third column
            dgvProducts.Columns[2].HeaderText = "Quantity On Hand";
            dgvProducts.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProducts.Columns[2].Width = 90;
            dgvProducts.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // format the forth column
            dgvProducts.Columns[3].HeaderText = "Unit Price";
            dgvProducts.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProducts.Columns[3].Width = 90;
            dgvProducts.Columns[3].DefaultCellStyle.Format = "c";
            dgvProducts.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // store index values for Modify and Delete button columns
            const int ModifyIndex = 4;
            const int DeleteIndex = 5; 

            if (e.ColumnIndex == ModifyIndex || e.ColumnIndex == DeleteIndex)
            {
                string productCode = dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                selectedProduct = GetProduct(productCode);
            }

            if (e.ColumnIndex == ModifyIndex)
            {
                ModifyProduct(e.RowIndex);
            }
            else if (e.ColumnIndex == DeleteIndex)
            {
                DeleteProduct();
            }
        }

        private Product GetProduct(string productCode)
        {
           foreach(Product p in productsInStock)
            {
                if (p.ProductCode.Equals(productCode)) return p;    
            }
            return null;

        }

        private void ModifyProduct(int indexOfOld)
        {
            
            var oldProduct = new Product
            {
                ProductCode = selectedProduct.ProductCode,
                Description = selectedProduct.Description,
                OnHandQuantity = selectedProduct.OnHandQuantity,
                UnitPrice = selectedProduct.UnitPrice
            };
            var addModifyProductForm = new frmAddModifyProduct()
            {
                AddProduct = false,
                Product = selectedProduct
            };
            DialogResult result = addModifyProductForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    
                    this.productsInStock[indexOfOld] = selectedProduct;
                    DisplayProducts();
                    
                  
                }
                
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }

        private void DeleteProduct()
        {
            DialogResult result =
                MessageBox.Show($"Delete {selectedProduct.ProductCode.Trim()}?",
                "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                 
                   if (productsInStock.Remove(selectedProduct))
                    {
                        DisplayProducts();
                    }
                   
                }
                
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addModifyProductForm = new frmAddModifyProduct()
            {
                AddProduct = true
            };
            DialogResult result = addModifyProductForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedProduct = addModifyProductForm.Product;
                    this.productsInStock.Add(selectedProduct);
                    DisplayProducts();
                }

                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }

        

        
        private void HandleGeneralError(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.GetType().ToString());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
