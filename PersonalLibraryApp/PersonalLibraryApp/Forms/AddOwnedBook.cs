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
    public partial class AddOwnedBook : Form
    {
        private Book book = new Book();
        private OwnedBooks ownedBook = new OwnedBooks();
        public AddOwnedBook()
        {
            InitializeComponent();
        }

        private void rbtnNewBook_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            txtDescription.Enabled = true;
        }

        private void rbtnExistingBook_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            txtDescription.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtnExistingBook.Checked)
            {
                if (ValidateForm())
                {
                    ownedBook = new OwnedBooks(book, true, dtpDateBought.Value);
                    this.Hide();
                }
            }
            else
            {
                if (ValidateForm())
                {
                    book = new Book(txtAuthorFName.Text, txtAuthorSName.Text, txtTitle.Text, txtDescription.Text);
                    ownedBook = new OwnedBooks(book, true, dtpDateBought.Value);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        internal OwnedBooks GetOwnedBook()
        {
            return ownedBook;
        }

        private bool ValidateForm()
        {
            if (txtTitle.Text == "")
            {
                MessageBox.Show("Please enter the title");
                return false;
            }
            if (txtAuthorFName.Text == "" || txtAuthorSName.Text == "")
            {
                MessageBox.Show("Please enter the author name");
                return false;
            }
            if (txtDescription.Text == "")
            {
                MessageBox.Show("Please describe the book");
                return false;
            }
            if (dtpDateBought.Value > DateTime.Now)
            {
                MessageBox.Show("Please enter a valid date");
                return false;
            }
            return true;
        }
    }
}
