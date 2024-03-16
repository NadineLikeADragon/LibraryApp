using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLibraryApp
{
    internal class WishList: Book
    {
        public double Price {  get; set; }
        public WishList(string bookId, string title, string description, string authorLastName) : base(bookId, title, description, authorLastName)
        {
            BookId = bookId;
            Title = title;
            Description = description;
            AuthorLastName = authorLastName;
        }
        public WishList(Book book, double price) // added book object to constructor
        {
            Price = price;
        }
        public WishList(string bookId, string title, string description, string authorLastName,double price) : base(bookId, title, description, authorLastName)
        {
            BookId = bookId;
            Title = title;
            Description = description;
            AuthorLastName = authorLastName;
            Price = price;
        }
        public WishList()
        {
        }

        
    }
}
