using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1
{
    class XMLHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Изменить файл типа XML");
           
        }

        public override void Create()
        {
            Console.WriteLine("Создать файл типа XML");
            
        }

        public override void Open()
        {
            Console.WriteLine("Открыть файл типа XML");
            
        }

        public override void Save()
        {
            Console.WriteLine("Сохранить файл типа XML");
            
        }
    }
}
