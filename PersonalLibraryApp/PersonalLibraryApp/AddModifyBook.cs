using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace PersonalLibraryApp
{
    public partial class AddModifyBook : Form
    {
        public Book Book { get; set; }
        public bool AddBook { get; set; }

        public AddModifyBook()
        {
            InitializeComponent();
        }

        private void DisplayBook()
        {
            txtBookId.Text = Book.BookId;
            txtTitle.Text = Book.Title;
            rtxtDescription.Text = Book.Description;
            txtSurname.Text = Book.AuthorLastName;
        }
        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            //errorMessage += Validator.IsPresent(txtBookId.Text, txtBookId.Tag.ToString());
            //errorMessage += Validator.IsPresent(txtTitle.Text, txtTitle.Tag.ToString());
            //errorMessage += Validator.IsPresent(rtxtDescription.Text, rtxtDescription.Tag.ToString());
            //errorMessage += Validator.IsPresent(txtSurname.Text, txtSurname.Tag.ToString());

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }

        private void LoadBookData()
        {
            Book.BookId = txtBookId.Text;
            Book.Title = txtTitle.Text;
            Book.Description = rtxtDescription.Text;
            Book.AuthorLastName = txtSurname.Text;
        }

        private void btnAddBook_Click_1(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (AddBook)
                {
                    // Initialize the Book property with a new Book object
                    this.Book = new Book();
                }
                LoadBookData();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void AddModifyBook_Load_1(object sender, EventArgs e)
        {

            if (AddBook)
            {
                this.Text = "Add Book";
                txtBookId.ReadOnly = false;  // Allow entry of new book ISBN
            }
            else
            {
                this.Text = "Modify Book";
                txtBookId.ReadOnly = true;   // Can't change existing book ISBN
                DisplayBook();
            }
        }
    }
}