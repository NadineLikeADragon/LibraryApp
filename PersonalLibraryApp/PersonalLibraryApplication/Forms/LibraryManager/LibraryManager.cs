using System.ComponentModel;
using System.Net;
using PersonalLibraryApplication.Models;

namespace PersonalLibraryApplication.Forms.LibraryManager
{
    public partial class LibraryManager : Form
    {
        List<OwnedBooks> ownedBooks = new List<OwnedBooks>();
        List<BooksRead> booksRead = new List<BooksRead>();
        List<WishList> wishListItems = new List<WishList>();
        List<LoanTracking> loanedBooks = new List<LoanTracking>();
        public LibraryManager()
        {
            loadDataToList();
            loadReadDataToList();
            loadWishlistDataToList();
            loadLoanDataToList();
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
        private void loadLoanDataToList()
        {
            DateTime date1 = Convert.ToDateTime("7/10/2023");
            DateTime date2 = Convert.ToDateTime("7/12/2023");
            LoanTracking b0 = new LoanTracking("B00HWN7NX0", "The Witcher: The Last Wish", "Geralt definitely kills only villians", "Andrzej Sapkowski", date1, date2);
            LoanTracking b1 = new LoanTracking("978-1368071062", "The Bob's Burgers Burger Book ", "Real Recipes for Joke Burgers", "Bouchard", date1, date2);
            loanedBooks.Add(b0);
            loanedBooks.Add(b1);
        }
        // create a list of loaned books
        private Book selectedBook;
        private OwnedBooks selectedOwnedBook;
        private BooksRead selectedReadBook;
        private WishList selectedWishlistItem;
        private LoanTracking selectedLoan;

        private void DisplayReadBooks()
        {
            dgvBooks.Columns.Clear();
            dgvBooks.DataSource = new BindingList<BooksRead>(booksRead.ToList());

            //Add column for modify button

            var modifyColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Modify"
            };
            dgvBooks.Columns.Add(modifyColumn);

            // Add column for delete button
            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
            dgvBooks.Columns.Add(deleteColumn);

            // Format the column headers
            dgvBooks.EnableHeadersVisualStyles = false;
            dgvBooks.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvBooks.ColumnHeadersDefaultCellStyle.BackColor = Color.MidnightBlue;
            dgvBooks.ColumnHeadersDefaultCellStyle.ForeColor = Color.Honeydew;

            // Format the odd-numbered rows
            dgvBooks.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            // Format the columns
            dgvBooks.Columns["BookId"].HeaderText = "Book ID";
            dgvBooks.Columns["Description"].Width = 240;
            dgvBooks.Columns["AuthorLastName"].HeaderText = "Author";
            dgvBooks.Columns["AuthorLastName"].Width = 120;
        }

        private void DisplayWishListBooks()
        {
            dgvBooks.Columns.Clear();
            dgvBooks.DataSource = new BindingList<WishList>(wishListItems.ToList());

            //Add column for modify button

            var modifyColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Modify"
            };
            dgvBooks.Columns.Add(modifyColumn);

            // Add column for delete button
            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
            dgvBooks.Columns.Add(deleteColumn);

            // Format the column headers
            dgvBooks.EnableHeadersVisualStyles = false;
            dgvBooks.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvBooks.ColumnHeadersDefaultCellStyle.BackColor = Color.MidnightBlue;
            dgvBooks.ColumnHeadersDefaultCellStyle.ForeColor = Color.Honeydew;

            // Format the odd-numbered rows
            dgvBooks.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            // Format the columns
            dgvBooks.Columns["BookId"].HeaderText = "Book ID";
            dgvBooks.Columns["Description"].Width = 240;
            dgvBooks.Columns["AuthorLastName"].HeaderText = "Author";
            dgvBooks.Columns["AuthorLastName"].Width = 120;
        }


        private void DisplayOwnedBooks()
        {
            dgvBooks.Columns.Clear();
            dgvBooks.DataSource = new BindingList<OwnedBooks>(ownedBooks.ToList());

            //Add column for modify button

            var modifyColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Modify"
            };
            dgvBooks.Columns.Add(modifyColumn);

            // Add column for delete button
            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
            dgvBooks.Columns.Add(deleteColumn);

            // Format the column headers
            dgvBooks.EnableHeadersVisualStyles = false;
            dgvBooks.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvBooks.ColumnHeadersDefaultCellStyle.BackColor = Color.MidnightBlue;
            dgvBooks.ColumnHeadersDefaultCellStyle.ForeColor = Color.Honeydew;

            // Format the odd-numbered rows
            dgvBooks.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            // Format the columns
            dgvBooks.Columns["BookId"].HeaderText = "Book ID";
            dgvBooks.Columns["Description"].Width = 240;
            dgvBooks.Columns["AuthorLastName"].HeaderText = "Author";
            dgvBooks.Columns["AuthorLastName"].Width = 120;
        }

        private void DisplayLoans()
        {
            dgvBooks.Columns.Clear();
            dgvBooks.DataSource = new BindingList<LoanTracking>(loanedBooks.ToList());

            //Add column for modify button

            var modifyColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Modify"
            };
            dgvBooks.Columns.Add(modifyColumn);

            // Add column for delete button
            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
            dgvBooks.Columns.Add(deleteColumn);

            // Format the column headers
            dgvBooks.EnableHeadersVisualStyles = false;
            dgvBooks.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvBooks.ColumnHeadersDefaultCellStyle.BackColor = Color.MidnightBlue;
            dgvBooks.ColumnHeadersDefaultCellStyle.ForeColor = Color.Honeydew;

            // Format the odd-numbered rows
            dgvBooks.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            // Format the columns
            dgvBooks.Columns["BookId"].HeaderText = "Book ID";
            dgvBooks.Columns["Description"].Width = 240;
            dgvBooks.Columns["AuthorLastName"].HeaderText = "Author";
            dgvBooks.Columns["AuthorLastName"].Width = 120;
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
        private OwnedBooks GetOwnedBook(string bookId)
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
        private LoanTracking GetLoan(string bookId)
        {
            foreach (LoanTracking book in loanedBooks)
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

        private void ModifyOwnedBook(int indexOfOld)
        {
            var addOwnedBookForm = new AddOwnedBook.AddOwnedBook
            {
                IsAdd = false,
                ownedBook = selectedOwnedBook,
            };
            DialogResult result = addOwnedBookForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    ownedBooks[indexOfOld] = addOwnedBookForm.GetOwnedBook();
                    DisplayOwnedBooks();
                }
                catch (Exception ex)
                {
                    HandleError(ex);
                }
            }
        }

        private void ModifyLoanBook(int indexOfOld)
        {
            var oldBook = new LoanTracking(selectedLoan.BookId, selectedLoan.Title, selectedLoan.Description, selectedLoan.AuthorLastName, selectedLoan.DateBorrowed, selectedLoan.DueDate);
            var addModifyLoanForm = new AddLoan.AddLoan
            {
                IsAdd = false,
                loan = selectedLoan,
            };
            DialogResult result = addModifyLoanForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    loanedBooks[indexOfOld] = addModifyLoanForm.loan;
                    DisplayLoans();
                }
                catch (Exception ex)
                {
                    HandleError(ex);
                }
            }
        }

        private void DeleteOwnedBook()
        {
            DialogResult result = MessageBox.Show($"Delete {selectedOwnedBook.BookId.Trim()}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (ownedBooks.Remove(selectedOwnedBook))
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

        private void DeleteLoanedBook()
        {
            DialogResult result = MessageBox.Show($"Delete {selectedLoan.BookId.Trim()}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (loanedBooks.Remove(selectedLoan))
                    {
                        DisplayLoans();
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
                    selectedOwnedBook = addModifyBookForm.Book;
                    ownedBooks.Add(selectedOwnedBook);
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
                btnAddOwned.Enabled = true;
                btnAddRead.Enabled = false;
                btnAddWishlist.Enabled = false;
                btnAddLoan.Enabled = false;
            }
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ModifyIndex = 0, DeleteIndex = 0;

            // ModifyDeleteOwnedBook logic extracted to a separate method and altered to handle all other child types

            if (rbVADOwned.Checked) // indices for the owned books DGV
            {
                ModifyIndex = 6;
                DeleteIndex = 7;

                ModifyDeleteOwnedBook(e, ModifyIndex, DeleteIndex);
            }
            else if (rbVADRead.Checked) // indices for the read books DGV
            {
                ModifyIndex = 7;
                DeleteIndex = 8;

                ModifyDeleteReadBook(e, ModifyIndex, DeleteIndex);
            }
            else if (rbVADWishlist.Checked) // indices for the wishlist DGV
            {
                ModifyIndex = 5;
                DeleteIndex = 6;

                ModifyDeleteWishListBook(e, ModifyIndex, DeleteIndex);
            }
            else if (rbVADLoans.Checked) // indices for the loaned books DGV
            {
                ModifyIndex = 6;
                DeleteIndex = 7;

                ModifyDeleteLoanBook(e, ModifyIndex, DeleteIndex);
            }
        }

        private void ModifyDeleteOwnedBook(DataGridViewCellEventArgs e, int ModifyIndex, int DeleteIndex)
        {
            if (e.ColumnIndex == ModifyIndex || e.ColumnIndex == DeleteIndex)
            {
                string bookId = dgvBooks.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                selectedOwnedBook = GetOwnedBook(bookId);
            }

            if (e.ColumnIndex == ModifyIndex)
            {
                ModifyOwnedBook(e.RowIndex);
                DisplayOwnedBooks();
            }
            else if (e.ColumnIndex == DeleteIndex)
            {
                DeleteOwnedBook();
                DisplayOwnedBooks();

            }
        }

        private void ModifyDeleteReadBook(DataGridViewCellEventArgs e, int ModifyIndex, int DeleteIndex)
        {
            if (e.ColumnIndex == ModifyIndex || e.ColumnIndex == DeleteIndex)
            {
                string bookId = dgvBooks.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
                selectedReadBook = GetReadBook(bookId);
            }

            if (e.ColumnIndex == ModifyIndex)
            {
                ModifyReadBook(e.RowIndex);
                DisplayReadBooks();
            }
            else if (e.ColumnIndex == DeleteIndex)
            {
                DeleteReadBook();
                DisplayReadBooks();
            }
        }

        private void ModifyDeleteWishListBook(DataGridViewCellEventArgs e, int ModifyIndex, int DeleteIndex)
        {
            if (e.ColumnIndex == ModifyIndex || e.ColumnIndex == DeleteIndex)
            {
                string bookId = dgvBooks.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                selectedWishlistItem = GetWishListBook(bookId);
            }

            if (e.ColumnIndex == ModifyIndex)
            {
                ModifyWishListBook(e.RowIndex);
            }
            else if (e.ColumnIndex == DeleteIndex)
            {
                DeleteWishListBook();
            }
        }

        private void ModifyDeleteLoanBook(DataGridViewCellEventArgs e, int ModifyIndex, int DeleteIndex)
        {
            if (e.ColumnIndex == ModifyIndex || e.ColumnIndex == DeleteIndex)
            {
                string bookId = dgvBooks.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                selectedLoan = GetLoan(bookId);
            }

            if (e.ColumnIndex == ModifyIndex)
            {
                ModifyLoanBook(e.RowIndex);
            }
            else if (e.ColumnIndex == DeleteIndex)
            {
                DeleteLoanedBook();
            }
        }

        private void dgvOwnedBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            const int ModifyIndex = 6;
            const int DeleteIndex = 7;

            if (e.ColumnIndex == ModifyIndex || e.ColumnIndex == DeleteIndex)
            {
                string bookId = dgvBooks.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                selectedOwnedBook = GetOwnedBook(bookId);
            }

            if (e.ColumnIndex == ModifyIndex)
            {
                ModifyOwnedBook(e.RowIndex);
            }
            else if (e.ColumnIndex == DeleteIndex)
            {
                DeleteOwnedBook();
            }
        }

        private void dgvReadBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            const int ModifyIndex = 7;
            const int DeleteIndex = 8;

            if (e.ColumnIndex == ModifyIndex || e.ColumnIndex == DeleteIndex)
            {
                string bookId = dgvBooks.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
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
                btnAddOwned.Enabled = false;
                btnAddRead.Enabled = true;
                btnAddWishlist.Enabled = false;
                btnAddLoan.Enabled = false;
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
                btnAddOwned.Enabled = false;
                btnAddRead.Enabled = false;
                btnAddWishlist.Enabled = true;
                btnAddLoan.Enabled = false;
                btnSwaptoOwned.Enabled = true;
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
            const int ModifyIndex = 5;
            const int DeleteIndex = 6;

            if (e.ColumnIndex == ModifyIndex || e.ColumnIndex == DeleteIndex)
            {
                string bookId = dgvBooks.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                selectedWishlistItem = GetWishListBook(bookId);
            }

            if (e.ColumnIndex == ModifyIndex)
            {
                ModifyOwnedBook(e.RowIndex);
            }
            else if (e.ColumnIndex == DeleteIndex)
            {
                DeleteOwnedBook();
            }
        }

        private void rbVADLoans_CheckedChanged(object sender, EventArgs e)
        {

            if (rbVADLoans.Checked)
            {
                DisplayLoans();
                btnAddRead.Enabled = false;
                btnAddOwned.Enabled = false;
                btnAddWishlist.Enabled = false;
                btnAddLoan.Enabled = true;
            }
        }

        private void btnAddLoan_Click(object sender, EventArgs e)
        {
            var addModifyLoanForm = new AddLoan.AddLoan()
            {
                IsAdd = true
            };

            DialogResult result = addModifyLoanForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedLoan = addModifyLoanForm.loan;
                    loanedBooks.Add(selectedLoan);
                    DisplayLoans();
                }
                catch (Exception ex)
                {
                    HandleError(ex);
                }
            }
        }

        private void rbVADWishListToOwned_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVADWishListToOwned.Checked)
            {
                DisplayWishListBooks();
                btnAddRead.Enabled = false;
                btnAddOwned.Enabled = false;
                btnAddWishlist.Enabled = false;
                btnAddLoan.Enabled = false;
                btnSwaptoOwned.Enabled = true;
            }
        }

        private void btnSwaptoOwned_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                var selectedRow = dgvBooks.SelectedRows[0];
                var selectedBook = selectedRow.DataBoundItem as WishList;
                if (selectedBook != null)
                {
                    DateTime date = DateTime.Now;
                    OwnedBooks ownedBook = new OwnedBooks(selectedBook.BookId, selectedBook.Title, selectedBook.Description, selectedBook.AuthorLastName, date);

                    wishListItems.Remove(selectedBook);

                    ownedBooks.Add(ownedBook);

                    DisplayOwnedBooks();
                }
            }
        }

        private void btnPrintToFile_Click(object sender, EventArgs e)
        {
            if (ownedBooks != null|| booksRead != null || wishListItems !=null || loanedBooks !=null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.Title = "Save Owned Books File";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            foreach (OwnedBooks book in ownedBooks)
                            {
                                writer.WriteLine("Book ID: " + book.BookId);
                                writer.WriteLine("Title: " + book.Title);
                                writer.WriteLine("Description: " + book.Description);
                                writer.WriteLine("Author: " + book.AuthorLastName);
                                writer.WriteLine("Date Acquired: " + book.DateBought.ToShortDateString() + "\n\n\n");
                            }
                            foreach (BooksRead book in booksRead)
                            {
                                writer.WriteLine("Book ID: " + book.BookId);
                                writer.WriteLine("Title: " + book.Title);
                                writer.WriteLine("Description: " + book.Description);
                                writer.WriteLine("Author: " + book.AuthorLastName);
                                writer.WriteLine("Date Finished: " + book.DateFinished);
                                writer.WriteLine("Review{ "+ book.Review + "\n\n\n");
                            }
                            foreach(WishList book in wishListItems)
                            {
                                writer.WriteLine("Book ID: " + book.BookId);
                                writer.WriteLine("Title: " + book.Title);
                                writer.WriteLine("Description: " + book.Description);
                                writer.WriteLine("Author: " + book.AuthorLastName);
                                writer.WriteLine("Price: " + book.Price + "\n\n\n");
                            }
                            foreach(LoanTracking book in loanedBooks)
                            {
                                writer.WriteLine("Book ID: " + book.BookId);
                                writer.WriteLine("Title: " + book.Title);
                                writer.WriteLine("Description: " + book.Description);
                                writer.WriteLine("Author: " + book.AuthorLastName);
                                writer.WriteLine("Date Borrowed: " + book.DateBorrowed);
                                writer.WriteLine("Return Date: " + book.DueDate + "\n\n\n");
                            }
                        }

                        MessageBox.Show("Personal Library saved to file successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while saving your Personal Library: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No Library data available to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}