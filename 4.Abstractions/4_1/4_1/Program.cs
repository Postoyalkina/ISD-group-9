using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1
{
    class Program
    {
        public static void Identify (AbstractHandler handler)
        {
            if (handler is DOCHandler) Console.WriteLine("Выбран файл типа DOC");
            else if (handler is XMLHandler) Console.WriteLine("Выбран файл типа XML");
            else if (handler is TXTHandler) Console.WriteLine("Выбран файл типа TXT");
            else throw new Exception("Неверный формат");
        }
        static void Main(string[] args)
        {
            DOCHandler doc = new DOCHandler();
            XMLHandler xml = new XMLHandler();
            TXTHandler txt = new TXTHandler();
            Identify(doc);
            doc.Create();
            doc.Open();
            doc.Change();
            doc.Save();
            Identify(xml);
            xml.Create();
            xml.Open();
            xml.Change();
            xml.Save();
            Identify(txt);
            txt.Create();
            txt.Open();
            txt.Change();
            txt.Save();
            Console.ReadKey();
        }
    }
}
