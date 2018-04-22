using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1
{
    class TXTHandler: AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Изменить файл типа TXT");
            
        }

        public override void Create()
        {
            Console.WriteLine("Создать файл типа TXT");
            
        }

        public override void Open()
        {
            Console.WriteLine("Открыть файл типа TXT");
            
        }

        public override void Save()
        {
            Console.WriteLine("Сохранить файл типа TXT");
            
        }
    }
}
