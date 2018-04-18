using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ClassRoom_inheritance_
{
    class ExcelentPupil : Pupil
    {
        public ExcelentPupil( string name):base(name)
        {

        }

        public override void Write()
        {
            Console.WriteLine("{0} пишет без ошибок", Name);
        }

        public override void Read()
        {
            Console.WriteLine("{0} читает каждый день", Name);
        }

        public override void Relax()
        {
            Console.WriteLine("{0} отдыхает, чтобы потом учиться опять",Name);
        }

        public override void Study()
        {
            Console.WriteLine("{0} - идеальный ученик",Name);
        }
    }
}
