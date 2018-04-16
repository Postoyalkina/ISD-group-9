using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Author
    {
        public string AuthorText { get; set; }
        public void Show()
        {
            Console.WriteLine("Author: " + AuthorText);
        }
    }
}
