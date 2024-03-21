using System.ComponentModel;
using PersonalLibraryApplication.Models;

namespace PersonalLibraryApplication.Forms.LibraryManager
{
    public partial class LibraryManager : Form
    {
        List<OwnedBooks> ownedBooks = new List<OwnedBooks>();
        List<BooksRead> booksRead = new List<BooksRead>();
        List<WishList> wishListItems = new List<WishList>();
        public LibraryManager()
        {
            loadDataToList();
            loadReadDataToList();
            loadWishlistDataToList();
            InitializeComponent();
        }

        private void LibraryManager_Load_1(object sender, EventArgs e)
        {

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
        private void loadWishlistDataToList()
        {

            WishList b0 = new WishList("978-1683833970", "Fallout: The Vault Dweller's Official Cookbook", "Enjoy some refreshing Nuka Cola, now with minimal radiation", "Victoria Rosenthal ", 17.50);
            wishListItems.Add(b0);
        }
        private void loadReadDataToList()
        {
            DateTime date1 = Convert.ToDateTime("7/10/2023");
            BooksRead b0 = new BooksRead("978-0544003415", "The Lord of the Rings", "Frodo does nothing, Sam does", "J.R.R Tolkien", true, date1, "Good Book, Legolas what a guy.");
            BooksRead b1 = new BooksRead("978-0441172719", "Dune", "Son becomes worm king", "Frank Herbert", false, date1, "Paul gets massive Worm");
            BooksRead b2 = new BooksRead("978-0349013329", "Anne of the Green Gables", "Somehow orphan child is endearing but irritating", "L.M Montgomery", true, date1, "Hate the love interest, Gilbert is annoying");
            booksRead.Add(b0);
            booksRead.Add(b1);
            booksRead.Add(b2);
        }
        private OwnedBooks selectedBook;
        private BooksRead selectedReadBook;
        private WishList selectedWishlistItem;

        private void DisplayReadBooks()
        {
            dgvReadBooks.Columns.Clear();
            dgvReadBooks.DataSource = new BindingList<BooksRead>(booksRead.ToList());

            //Add column for modify button

            var modifyColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Modify"
            };
            dgvReadBooks.Columns.Add(modifyColumn);

            // Add column for delete button
            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
            dgvReadBooks.Columns.Add(deleteColumn);

            // Format the column headers
            dgvReadBooks.EnableHeadersVisualStyles = false;
            dgvReadBooks.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvReadBooks.ColumnHeadersDefaultCellStyle.BackColor = Color.MidnightBlue;
            dgvReadBooks.ColumnHeadersDefaultCellStyle.ForeColor = Color.Honeydew;

            // Format the odd-numbered rows
            dgvReadBooks.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            // Format the columns
            dgvReadBooks.Columns["BookId"].HeaderText = "Book ID";
            dgvReadBooks.Columns["Description"].Width = 240;
            dgvReadBooks.Columns["AuthorLastName"].HeaderText = "Author";
            dgvReadBooks.Columns["AuthorLastName"].Width = 120;
        }

        private void DisplayWishListBooks()
        {
            dgvWishlistBooks.Columns.Clear();
            dgvWishlistBooks.DataSource = new BindingList<WishList>(wishListItems.ToList());

            //Add column for modify button

            var modifyColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Modify"
            };
            dgvWishlistBooks.Columns.Add(modifyColumn);

            // Add column for delete button
            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
            dgvWishlistBooks.Columns.Add(deleteColumn);

            // Format the column headers
            dgvWishlistBooks.EnableHeadersVisualStyles = false;
            dgvWishlistBooks.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvWishlistBooks.ColumnHeadersDefaultCellStyle.BackColor = Color.MidnightBlue;
            dgvWishlistBooks.ColumnHeadersDefaultCellStyle.ForeColor = Color.Honeydew;

            // Format the odd-numbered rows
            dgvWishlistBooks.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            // Format the columns
            dgvWishlistBooks.Columns["BookId"].HeaderText = "Book ID";
            dgvWishlistBooks.Columns["Description"].Width = 240;
            dgvWishlistBooks.Columns["AuthorLastName"].HeaderText = "Author";
            dgvWishlistBooks.Columns["AuthorLastName"].Width = 120;
        }


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
        private BooksRead GetReadBook(string bookId)
        {
            foreach (BooksRead book in booksRead)
            {
                if (book.BookId.Equals(bookId))
                {
                    return book;
                }
            }
            return null;
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
        private WishList GetWishListBook(string bookId)
        {
            foreach (WishList book in wishListItems)
            {
                if (book.BookId.Equals(bookId))
                {
                    return book;
                }
            }
            return null;
        }
        private void ModifyReadBook(int indexOfOld)
        {
            var oldBook = new BooksRead
            {
                BookId = selectedReadBook.BookId,
                Title = selectedReadBook.Title,
                Description = selectedReadBook.Description,
                AuthorLastName = selectedReadBook.AuthorLastName,
                Owned = selectedReadBook.Owned,
                DateFinished = selectedReadBook.DateFinished,
                Review = selectedReadBook.Review,
            };
            var addModifyBookForm = new AddBookRead.AddBookRead
            {
                AddBook = false,
                Book = selectedReadBook,
            };
            DialogResult result = addModifyBookForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    booksRead[indexOfOld] = selectedReadBook;
                    DisplayReadBooks();
                }
                catch (Exception ex)
                {
                    HandleError(ex);
                }
            }
        }
        private void ModifyWishListBook(int indexOfOld)
        {
            var oldBook = new WishList
            {
                BookId = selectedWishlistItem.BookId,
                Title = selectedWishlistItem.Title,
                Description = selectedWishlistItem.Description,
                AuthorLastName = selectedWishlistItem.AuthorLastName,
                Price = selectedWishlistItem.Price,
            };
            var addModifyBookForm = new AddWishList.AddWishList
            {
                IsAdd = false,
                book = selectedWishlistItem,
            };
            DialogResult result = addModifyBookForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    wishListItems[indexOfOld] = selectedWishlistItem;
                    DisplayWishListBooks();
                }
                catch (Exception ex)
                {
                    HandleError(ex);
                }
            }
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
            var addModifyBookForm = new AddModifyBook.AddModifyBook()
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
            DialogResult result = MessageBox.Show($"Delete {selectedBook.BookId.Trim()}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (ownedBooks.Remove(selectedBook))
                    {
                        DisplayReadBooks();
                    }
                }
                catch (Exception ex)
                {
                    HandleError(ex);
                }
            }
        }

        private void DeleteReadBook()
        {
            DialogResult result = MessageBox.Show($"Delete {selectedReadBook.BookId.Trim()}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (booksRead.Remove(selectedReadBook))
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

        private void DeleteWishListBook()
        {
            DialogResult result = MessageBox.Show($"Delete {selectedWishlistItem.BookId.Trim()}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (wishListItems.Remove(selectedWishlistItem))
                    {
                        DisplayWishListBooks();
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

            var addModifyBookForm = new AddModifyBook.AddModifyBook()
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
            const int ModifyIndex = 6;
            const int DeleteIndex = 7;

            if (e.ColumnIndex == ModifyIndex || e.ColumnIndex == DeleteIndex)
            {
                string bookId = dgvOwnedBooks.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
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

        private void dgvReadBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            const int ModifyIndex = 7;
            const int DeleteIndex = 8;

            if (e.ColumnIndex == ModifyIndex || e.ColumnIndex == DeleteIndex)
            {
                string bookId = dgvReadBooks.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
                selectedReadBook = GetReadBook(bookId);
            }

            if (e.ColumnIndex == ModifyIndex)
            {
                ModifyReadBook(e.RowIndex);
            }
            else if (e.ColumnIndex == DeleteIndex)
            {
                DeleteReadBook();
            }
        }

        private void rbVADRead_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVADRead.Checked)
            {
                DisplayReadBooks();
                btnAddRead.Visible = true;
            }
        }

        private void btnAddRead_Click(object sender, EventArgs e)
        {

            var addModifyBookForm = new AddBookRead.AddBookRead()
            {
                AddBook = true
            };
            DialogResult result = addModifyBookForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedReadBook = addModifyBookForm.Book;
                    booksRead.Add(selectedReadBook);
                    DisplayReadBooks();
                }
                catch (Exception ex)
                {
                    HandleError(ex);
                }
            }
        }

        private void rbVADWishlist_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVADWishlist.Checked)
            {
                DisplayWishListBooks();
                btnAddWishlist.Visible = true;
            }
        }

        private void btnAddWishlist_Click(object sender, EventArgs e)
        {
            var addModifyBookForm = new AddWishList.AddWishList()
            {
                IsAdd = true
            };
            DialogResult result = addModifyBookForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedWishlistItem = (WishList)addModifyBookForm.book;
                    wishListItems.Add(selectedWishlistItem);
                    DisplayWishListBooks();
                }
                catch (Exception ex)
                {
                    HandleError(ex);
                }
            }
        }

        private void dgvWishlistBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            const int ModifyIndex = 6;
            const int DeleteIndex = 7;

            if (e.ColumnIndex == ModifyIndex || e.ColumnIndex == DeleteIndex)
            {
                string bookId = dgvWishlistBooks.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                selectedWishlistItem = GetWishListBook(bookId);
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