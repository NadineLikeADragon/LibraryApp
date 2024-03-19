﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PersonalLibraryApp
{
    public partial class LibraryManager : Form
    {
        List<OwnedBooks> booksInStock = new List<OwnedBooks>();
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
            OwnedBooks b0 = new OwnedBooks("B001", "Book 1", "Description 1", "Author 1", date1);
            OwnedBooks b1 = new OwnedBooks("B002", "Book 2", "Description 2", "Author 2", date1);
            OwnedBooks b2 = new OwnedBooks("B003", "Book 3", "Description 3", "Author 3", date1);
            booksInStock.Add(b0);
            booksInStock.Add(b1);
            booksInStock.Add(b2);
        }

        private OwnedBooks selectedBook;


        private void DisplayOwnedBooks()
        {
            dgvOwnedBooks.Columns.Clear();
            dgvOwnedBooks.DataSource = new BindingList<OwnedBooks>(booksInStock.ToList());

            // Add column for modify button
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
            dgvOwnedBooks.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine;
            dgvOwnedBooks.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

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
            foreach (OwnedBooks book in booksInStock)
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
                    booksInStock[indexOfOld] = selectedBook;
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
                    if (booksInStock.Remove(selectedBook))
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
                    booksInStock.Add(selectedBook);
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
            }
        }

        private void dgvOwnedBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            const int ModifyIndex = 4;
            const int DeleteIndex = 5;

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