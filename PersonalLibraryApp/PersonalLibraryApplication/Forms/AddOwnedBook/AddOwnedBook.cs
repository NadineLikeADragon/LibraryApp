using PersonalLibraryApplication.Models;

namespace PersonalLibraryApplication.Forms.AddOwnedBook;

public partial class AddOwnedBook : Form
{
    internal Book book { get; set;}
    internal OwnedBooks ownedBook { get; set; }
    public bool IsAdd { get; set; }
    public AddOwnedBook()
    {
        InitializeComponent();
    }

    private void AddOwnedBook_Load(object sender, EventArgs e)
    {
        if (IsAdd)
        {
            txtBookID.Enabled = true;
        }
        else
        {
            txtBookID.Enabled = false;
            SetOwnedBookFields(ownedBook);
        }
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
        if (ValidateForm())
        {
            this.book = new Book(txtBookID.Text, txtTitle.Text, txtDescription.Text, txtAuthorSName.Text);
            ownedBook = new OwnedBooks(book, true, dtpDateBought.Value);
            this.DialogResult = DialogResult.OK;
            this.Hide();
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
        if (dtpDateBought.Value > DateTime.Now)
        {
            MessageBox.Show("Date bought cannot be in the future");
            return false;
        }
        return true;
    }

    private void SetOwnedBookFields(OwnedBooks ownedBook)
    {
        txtBookID.Text = ownedBook.BookId;
        txtTitle.Text = ownedBook.Title;
        txtDescription.Text = ownedBook.Description;
        txtAuthorSName.Text = ownedBook.AuthorLastName;

        dtpDateBought.Value = ownedBook.DateBought;
    }
}