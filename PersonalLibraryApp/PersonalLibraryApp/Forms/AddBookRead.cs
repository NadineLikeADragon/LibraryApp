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
    public partial class AddBookRead : Form
    {
        internal BooksRead bookRead = new BooksRead();
        public bool IsAdd { get; set; }

        public AddBookRead()
        {
            InitializeComponent();
        }

        private void AddBookRead_Load(object sender, EventArgs e)
        {
            if (IsAdd)
            {
                txtBookID.Enabled = true;
            }
            else
            {
                txtBookID.Enabled = false;
                SetBookReadFields(bookRead);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                bookRead = new BooksRead(txtBookID.Text, txtTitle.Text, txtDescription.Text, txtAuthorSName.Text, chkOwned.Checked, dtpDateFinished.Value, txtReview.Text);

                this.Hide();
            }
        }

        private void SetBookReadFields(Book book)
        {
            txtBookID.Text = book.BookId;
            txtTitle.Text = book.Title;
            txtDescription.Text = book.Description;
            txtAuthorSName.Text = book.AuthorLastName;
            dtpDateFinished.Value = bookRead.DateFinished;
            chkOwned.Checked = bookRead.Owned;
            txtReview.Text = bookRead.Review;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            if (dtpDateFinished.Value > DateTime.Now)
            {
                MessageBox.Show("Please enter a valid date");
                return false;
            }
            return true;
        }
    }
}
