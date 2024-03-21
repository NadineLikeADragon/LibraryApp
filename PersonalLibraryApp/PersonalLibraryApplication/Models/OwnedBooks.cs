namespace PersonalLibraryApplication.Models
{
    public class OwnedBooks : Book
    {
        public bool Owned {  get; set; }
        public DateTime DateBought { get; set; }

        // TODO: Ctor from old main.
        public OwnedBooks(string bookId, string title, string description, string authorLastName, DateTime dateBought)
            : base(bookId, title, description, authorLastName)
        {
            DateBought = dateBought;
        }
        
        
        // TODO: Ctor's from Kieran Branch.
        public OwnedBooks(string bookId, string title, string description, string authorLastName) : base(bookId, title, description, authorLastName)
        {
            BookId = bookId;
            Title = title;
            Description = description;
            AuthorLastName = authorLastName;
        }

        public OwnedBooks(Book book, bool owned, DateTime dateBought) // add book object to constructor
        {
            BookId = book.BookId;
            Title = book.Title;
            Description = book.Description;
            AuthorLastName = book.AuthorLastName;
            Owned = owned;
            DateBought = dateBought;
        }
        public OwnedBooks(string bookId, string title, string description, string authorLastName, bool owned, DateTime dateBought) : base(bookId, title, description, authorLastName)
        {
            BookId = bookId;
            Title = title;
            Description = description;
            AuthorLastName = authorLastName;
            Owned = owned;
            DateBought = dateBought;
        }

        public OwnedBooks() 
        {
            BookId = "";
            Title = "";
            Description = "";
            AuthorLastName = "";
            Owned = false;
            DateBought = DateTime.Now;
        }
    }
}