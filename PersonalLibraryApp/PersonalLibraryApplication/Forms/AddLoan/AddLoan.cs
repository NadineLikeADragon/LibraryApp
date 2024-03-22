using PersonalLibraryApplication.Models;

namespace PersonalLibraryApplication.Forms.AddLoan;

public partial class AddLoan : Form
{
    internal LoanTracking loan;
    public bool IsAdd { get; set; }
    public AddLoan()
    {
        InitializeComponent();
    }

    private void AddLoan_Load(object sender, EventArgs e)
    {
        if (IsAdd)
        {
            txtBookID.Enabled = true;
        }
        else
        {
            txtBookID.Enabled = false;
            SetLoanFields(loan);
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (ValidateForm())
        {
            loan = new LoanTracking(txtBookID.Text, txtTitle.Text, txtDescription.Text, txtAuthorSName.Text, dtpDateBorrowed.Value, dtpDueDate.Value);
            this.DialogResult = DialogResult.OK;

            this.Hide();
        }
    }

    internal LoanTracking GetLoan()
    {
        return loan;
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
        if (dtpDateBorrowed.Value > dtpDueDate.Value)
        {
            MessageBox.Show("The due date must be after the date borrowed");
            return false;
        }
        if (dtpDateBorrowed.Value > DateTime.Now)
        {
            MessageBox.Show("The date borrowed must be in the past");
            return false;
        }
        return true;
    }

    private void SetLoanFields(LoanTracking loan)
    {
        txtBookID.Text = loan.BookId;
        txtTitle.Text = loan.Title;
        txtDescription.Text = loan.Description;
        txtAuthorSName.Text = loan.AuthorLastName;
        dtpDateBorrowed.Value = loan.DateBorrowed;
        dtpDueDate.Value = loan.DueDate;
    }

    private void AddLoan_Load_1(object sender, EventArgs e)
    {

    }
}