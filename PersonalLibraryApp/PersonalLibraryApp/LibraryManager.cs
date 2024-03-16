using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PersonalLibraryApp
{
    public partial class LibraryApp : Form
    {
        List<Book> books = new List<Book>();
        public LibraryApp()
        {
            InitializeComponent();
            loadOwnedDataToList();
            loadReadDataToList();
            loadWishlistDataToList();
        }
        private void loadOwnedDataToList()
        {
            DateTime o1date = Convert.ToDateTime("8th Decemeber 1994");
            OwnedBooks o1 = new OwnedBooks("9780544003415", "The Lord of the Rings", "Frodo throws a ring in big volcano", "Tolkien", true, o1date);
         
            this.books.Add(o1);
        }
        private void loadReadDataToList()
        {
            OwnedBooks o1 = new OwnedBooks("9780544003415", "The Lord of the Rings", "Frodo throws a ring in big volcano", "Tolkien");

            //this.productsInStock.Add(p0);
            //this.productsInStock.Add(p1);
            //this.productsInStock.Add(p2);
            //this.productsInStock.Add(p3);



        }
        //private Book selectedBook;

        

        private void DisplayOwnedBooks()
        {
            dgvOwnedBooks.Columns.Clear();
            dgvOwnedBooks.DataSource = new BindingList<Book>(this.books.ToList());

            // add column for modify button
            var modifyColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Modify"
            };
            dgvOwnedBooks.Columns.Add(modifyColumn);

            // add column for delete button
            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
            dgvOwnedBooks.Columns.Add(deleteColumn);

            // format the column header
            dgvOwnedBooks.EnableHeadersVisualStyles = false;
            dgvOwnedBooks.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvOwnedBooks.ColumnHeadersDefaultCellStyle.BackColor = Color.Goldenrod;
            dgvOwnedBooks.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // format the odd numbered rows
            dgvOwnedBooks.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGoldenrod;

            // format the first column
            dgvOwnedBooks.Columns[0].HeaderText = "Product Code";
            dgvOwnedBooks.Columns[0].Width = 110;

            // format the second column
            dgvOwnedBooks.Columns[1].Width = 240;

            // format the third column
            dgvOwnedBooks.Columns[2].HeaderText = "Quantity On Hand";
            dgvOwnedBooks.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvOwnedBooks.Columns[2].Width = 90;
            dgvOwnedBooks.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // format the forth column
            dgvOwnedBooks.Columns[3].HeaderText = "Unit Price";
            dgvOwnedBooks.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvOwnedBooks.Columns[3].Width = 90;
            dgvOwnedBooks.Columns[3].DefaultCellStyle.Format = "c";
            dgvOwnedBooks.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }





        private void loadWishlistDataToList()
        {
            OwnedBooks o1 = new OwnedBooks("9780544003415", "The Lord of the Rings", "Frodo throws a ring in big volcano", "Tolkien");

            //this.productsInStock.Add(p0);
            //this.productsInStock.Add(p1);
            //this.productsInStock.Add(p2);
            //this.productsInStock.Add(p3);



        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            String  ownedbtn = this.rbVADOwned.Text;
            bool owned = Convert.ToBoolean(ownedbtn);
            if (owned == true)
            {
                DisplayOwnedBooks();
            }
        }
    }
}
