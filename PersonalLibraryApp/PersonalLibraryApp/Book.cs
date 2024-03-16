using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLibraryApp
{
    public class Book
    {
        public string BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AuthorLastName { get; set; }

        public Book(string bookId, string title, string description, string authorLastName)
        {
            BookId = bookId;
            Title = title;
            Description = description;
            AuthorLastName = authorLastName;
        }

        public Book() { }

        public virtual string Print()
        {
            return $"BookId: {BookId}\nTitle: {Title}\nDescription: {Description}\nAuthor Name: {AuthorLastName}";
        }
    }
}