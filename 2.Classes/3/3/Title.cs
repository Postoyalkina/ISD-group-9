using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Title
    {
        public string TitleText { get; set; }
        public void Show()
        {
            Console.WriteLine("Title: " + TitleText);
        }
    }
}
