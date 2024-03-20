namespace PersonalLibraryApplication.Models
{
    public class OwnedBooks : Book
    {
        public DateTime DateBought { get; set; }

        public OwnedBooks(string bookId, string title, string description, string authorLastName, DateTime dateBought)
            : base(bookId, title, description, authorLastName)
        {
            DateBought = dateBought;
        }

        public OwnedBooks() { }
    }
}