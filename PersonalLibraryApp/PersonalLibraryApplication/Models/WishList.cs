﻿namespace PersonalLibraryApplication.Models
{
    public class WishList: Book
    {
        

        public double Price {  get; set; }
        public WishList(string bookId, string title, string description, string authorLastName) : base(bookId, title, description, authorLastName)
        {
            BookId = bookId;
            Title = title;
            Description = description;
            AuthorLastName = authorLastName;

        }
        public WishList(double price)
        {
            Price = price;
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
            BookId = "";
            Title = "";
            Description = "";
            AuthorLastName = "";
            Price = 0;
        }

        
    }
}
