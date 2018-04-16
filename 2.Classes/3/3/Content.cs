using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Content
    {
        public string ContentText { get; set; }
        public void Show()
        {
            Console.WriteLine("Content: " + ContentText);
        }
    }
}
