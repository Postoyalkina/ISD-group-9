using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Book
    {
        public Title BookTitle { get; set; }
        public Author BookAuthor { get; set; }
        public Content BookContent { get; set; }

        public Book(string title, string author, string content)
        {
            BookTitle = new Title
            {
                TitleText = title
            };
            BookAuthor = new Author
            {
                AuthorText = author
            };
            BookContent = new Content
            {
                ContentText = content
            };
        }
    }
}
