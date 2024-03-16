using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLibraryApp
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