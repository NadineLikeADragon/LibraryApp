namespace PersonalLibraryApplication.Models
{
    public class BooksRead : Book
    {
        public bool Owned { get; set; }
        public DateTime DateFinished { get; set; }
        public string Review { get; set; }

        public BooksRead(string bookId, string title, string description, string authorLastName)
            : base(bookId, title, description, authorLastName)
        {
        }

        public BooksRead(bool owned, DateTime dateFinished, string review)
        {
            Owned = owned;
            DateFinished = dateFinished;
            Review = review;
        }

        public BooksRead(string bookId, string title, string description, string authorLastName, bool owned, DateTime dateFinished, string review)
            : base(bookId, title, description, authorLastName)
        {
            Owned = owned;
            DateFinished = dateFinished;
            Review = review;
        }

        public BooksRead()
        {
        }
    }
}
