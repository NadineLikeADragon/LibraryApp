using PersonalLibraryApplication.Models;

namespace PersonalLibraryApplication.Forms.AddBookRead
{

    public partial class AddBookRead : Form
    {
        public BooksRead Book { get; set; }
        public bool AddBook { get; set; }

        public AddBookRead()
        {
            InitializeComponent();
        }

        private void DisplayBook()
        {
            txtBookID.Text = Book.BookId;
            txtTitle.Text = Book.Title;
            txtDescription.Text = Book.Description;
            txtAuthorSName.Text = Book.AuthorLastName;
            txtReview.Text = Book.Review;
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
            Book.BookId = txtBookID.Text;
            Book.Title = txtTitle.Text;
            Book.Description = txtDescription.Text;
            Book.AuthorLastName = txtAuthorSName.Text;
            Book.DateFinished = Convert.ToDateTime(dtpDateFinished.Text);
            txtReview.Text = Book.Review;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (AddBook)
                {
                    // Initialize the Book property with a new Book object
                    this.Book = new BooksRead();
                }
                LoadBookData();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void AddBookRead_Load(object sender, EventArgs e)
        {
            if (AddBook)
            {
                this.Text = "Add Book";
                txtBookID.ReadOnly = false;  // Allow entry of new book ISBN
            }
            else
            {
                this.Text = "Modify Book";
                txtBookID.ReadOnly = true;   // Can't change existing book ISBN
                DisplayBook();
            }
        }
    }
}
