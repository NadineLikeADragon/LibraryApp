using PersonalLibraryApplication.Models;
namespace PersonalLibraryApplication.Forms.AddWishList
{
    public partial class AddWishList : Form
    {
        public WishList book { get; set; } // Change the property name to Book and the type to WishList
        public bool IsAdd { get; set; }

        public AddWishList()
        {
            InitializeComponent();
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

        private void DisplayBook()
        {
            txtBookID.Text = book.BookId;
            txtTitle.Text = book.Title;
            txtDescription.Text = book.Description;
            txtAuthorSName.Text = book.AuthorLastName;
            txtPrice.Text = book.Price.ToString(); // Convert price to string for display
        }

        private void LoadBookData()
        {
            book.BookId = txtBookID.Text;
            book.Title = txtTitle.Text;
            book.Description = txtDescription.Text;
            book.AuthorLastName = txtAuthorSName.Text;
            book.Price = Convert.ToDouble(txtPrice.Text);
        }


        private void AddWishList_Load(object sender, EventArgs e)
        {

            if (IsAdd)
            {
                this.Text = "Add Book";
                txtBookID.ReadOnly = false;  // Allow entry of new book ID
            }
            else
            {
                this.Text = "Modify Book";
                txtBookID.ReadOnly = true;   // Can't change existing book ID
                DisplayBook();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (IsAdd)
                {
                    // Initialize the Book property with a new WishList object
                    this.book = new WishList();
                }
                LoadBookData();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}