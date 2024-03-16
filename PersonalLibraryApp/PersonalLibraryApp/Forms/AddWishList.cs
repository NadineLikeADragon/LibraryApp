using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalLibraryApp.Forms
{
    public partial class AddWishList : Form
    {
        private WishList wishList = new WishList();
        private Book book = new Book();
        public bool IsAdd { get; set; }
        public AddWishList()
        {
            InitializeComponent();
        }

        private void AddWishList_Load(object sender, EventArgs e)
        {
            if (IsAdd)
            {
                txtBookID.Enabled = true;
            }
            else
            {
                txtBookID.Enabled = false;
                SetBookFields(wishList);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Book book = new Book(txtBookID.Text, txtTitle.Text, txtDescription.Text, txtAuthorSName.Text);
                WishList wishList = new WishList(book, Double.Parse(txtPrice.Text));
            }

        }

        internal WishList GetWishList()
        {
            return wishList;
        }

        internal void SetBook(Book book)
        {
            this.book = book;
        }

        private bool ValidateForm()
        {
            if (txtTitle.Text == "")
            {
                MessageBox.Show("Please enter the title");
                return false;
            }
            if (txtBookID.Text == "")
            {
                MessageBox.Show("Please enter the book ID");
                return false;
            }
            if (txtAuthorSName.Text == "")
            {
                MessageBox.Show("Please enter the author name");
                return false;
            }
            if (txtDescription.Text == "")
            {
                MessageBox.Show("Please describe the book");
                return false;
            }
            if (txtPrice.Text == "")
            {
                MessageBox.Show("Please enter the price");
                return false;
            }
            return true;
        }

        private void SetBookFields(Book book)
        {
            txtBookID.Text = book.BookId;
            txtTitle.Text = book.Title;
            txtDescription.Text = book.Description;
            txtAuthorSName.Text = book.AuthorLastName;
        }
    }
}
