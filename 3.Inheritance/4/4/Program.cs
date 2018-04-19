using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ProKeys = new List<string>()
            {
                "hd7","s6d","s7u"
            };
            List<string> ExpKeys = new List<string>()
            {
                "8jd","s8j","pso"
            };
            Console.WriteLine("Введите ключ");
            string o;
            DocumentWorker DW;
            o = Console.ReadLine();
            if (ProKeys.Contains(o))
            {
                DW = new ProDocumentWorker();
                Console.WriteLine("Вы ввели ключ Pro");
            }                               
            else if (ExpKeys.Contains(o))
            {
                DW = new ExpertDocumentWorker();
                Console.WriteLine("Вы ввели ключ Exp");
            }                
            else
            {
                DW = new DocumentWorker();
                Console.WriteLine("Ключ не правильный");
            }
            DW.OpenDocument();
            DW.EditDocument();
            DW.SaveDocument();
            Console.ReadKey();
            
        }

    }

    class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }
    }

    class ProDocumentWorker : DocumentWorker
    {
        
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }
    }

    class ExpertDocumentWorker :ProDocumentWorker
    {

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}
