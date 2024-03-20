using PersonalLibraryApplication.Models;

namespace PersonalLibraryApplication.Forms.AddBook;

public partial class AddBook : Form
{
	private Book book = new Book();
	public AddBook()
	{
		InitializeComponent();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		this.Hide();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		if (ValidateForm())
		{
			book = new Book(txtBookID.Text, txtTitle.Text, txtDescription.Text, txtAuthorSName.Text);

			this.Hide();
		}
	}

	internal Book GetBook()
	{
		return book;
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