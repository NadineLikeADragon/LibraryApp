using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PersonalLibraryApp
{
    public partial class LibraryManager : Form
    {
        List<OwnedBooks> ownedBooks = new List<OwnedBooks>();
        public LibraryManager()
        {
            loadDataToList();
            InitializeComponent();
        }

        private void LibraryManager_Load_1(object sender, EventArgs e)
        {
            //DisplayOwnedBooks();
        }
        private void loadDataToList()
        {
            DateTime date1 = Convert.ToDateTime("7/10/2023");
            OwnedBooks b0 = new OwnedBooks("978-0544003415", "The Lord of the Rings", "Frodo does nothing, Sam does", "J.R.R Tolkien", date1);
            OwnedBooks b1 = new OwnedBooks("978-0441172719", "Dune", "Son becomes worm king", "Frank Herbert", date1);
            OwnedBooks b2 = new OwnedBooks("978-0349013329", "Anne of the Green Gables", "Somehow orphan child is endearing but irritating", "L.M Montgomery", date1);
            ownedBooks.Add(b0);
            ownedBooks.Add(b1);
            ownedBooks.Add(b2);
        }

        private OwnedBooks selectedBook;


        private void DisplayOwnedBooks()
        {
            dgvOwnedBooks.Columns.Clear();
            dgvOwnedBooks.DataSource = new BindingList<OwnedBooks>(ownedBooks.ToList());

            //Add column for modify button

           var modifyColumn = new DataGridViewButtonColumn()
           {
               UseColumnTextForButtonValue = true,
               HeaderText = "",
               Text = "Modify"
           };
            dgvOwnedBooks.Columns.Add(modifyColumn);

            // Add column for delete button
            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
            dgvOwnedBooks.Columns.Add(deleteColumn);

            // Format the column headers
            dgvOwnedBooks.EnableHeadersVisualStyles = false;
            dgvOwnedBooks.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvOwnedBooks.ColumnHeadersDefaultCellStyle.BackColor = Color.MidnightBlue;
            dgvOwnedBooks.ColumnHeadersDefaultCellStyle.ForeColor = Color.Honeydew;

            // Format the odd-numbered rows
            dgvOwnedBooks.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            // Format the columns
            dgvOwnedBooks.Columns["BookId"].HeaderText = "Book ID";
            dgvOwnedBooks.Columns["Description"].Width = 240;
            dgvOwnedBooks.Columns["AuthorLastName"].HeaderText = "Author";
            dgvOwnedBooks.Columns["AuthorLastName"].Width = 120;
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private OwnedBooks GetBook(string bookId)
        {
            foreach (OwnedBooks book in ownedBooks)
            {
                if (book.BookId.Equals(bookId))
                {
                    return book;
                }
            }
            return null;
        }

        private void ModifyBook(int indexOfOld)
        {
            var oldBook = new OwnedBooks
            {
                BookId = selectedBook.BookId,
                Title = selectedBook.Title,
                Description = selectedBook.Description,
                AuthorLastName = selectedBook.AuthorLastName,
                DateBought = selectedBook.DateBought,
            };
            var addModifyBookForm = new AddModifyBook()
            {
                AddBook = false,
                Book = selectedBook
            };
            DialogResult result = addModifyBookForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    ownedBooks[indexOfOld] = selectedBook;
                    DisplayOwnedBooks();
                }
                catch (Exception ex)
                {
                    HandleError(ex);
                }
            }
        }

        private void DeleteBook()
        {
            DialogResult result = MessageBox.Show($"Delete {selectedBook.BookId.Trim()}?", "Confirm Delete", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (ownedBooks.Remove(selectedBook))
                    {
                        DisplayOwnedBooks();
                    }
                }
                catch (Exception ex)
                {
                    HandleError(ex);
                }
            }
        }

        private void HandleError(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.GetType().ToString());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddOwned_Click(object sender, EventArgs e)
        {

            var addModifyBookForm = new AddModifyBook()
            {
                AddBook = true
            };
            DialogResult result = addModifyBookForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedBook = addModifyBookForm.Book;
                    ownedBooks.Add(selectedBook);
                    DisplayOwnedBooks();
                }
                catch (Exception ex)
                {
                    HandleError(ex);
                }
            }
        }

        private void rbVADOwned_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVADOwned.Checked)
            {
                DisplayOwnedBooks();
                btnAddOwned.Visible = true;
            }
        }

        private void dgvOwnedBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            const int ModifyIndex = 5;
            const int DeleteIndex = 6;

            if (e.ColumnIndex == ModifyIndex || e.ColumnIndex == DeleteIndex)
            {
                string bookId = dgvOwnedBooks.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                selectedBook = GetBook(bookId);
            }

            if (e.ColumnIndex == ModifyIndex)
            {
                ModifyBook(e.RowIndex);
            }
            else if (e.ColumnIndex == DeleteIndex)
            {
                DeleteBook();
            }
        }

    }
 }