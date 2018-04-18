using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ClassRoom_inheritance_
{
    class GoodPupil:Pupil
    {
        public GoodPupil(string name) : base(name)
        {

        }

        public override void Write()
        {
            Console.WriteLine("{0} пишет практически без ошибок", Name);
        }

        public override void Read()
        {
            Console.WriteLine("{0} читает по-немногу каждый день", Name);
        }

        public override void Relax()
        {
            Console.WriteLine("{0} отдыхает, сделав все домашние задания", Name);
        }

        public override void Study()
        {
            Console.WriteLine("{0} - хороший ученик", Name);
        }
    }
}
