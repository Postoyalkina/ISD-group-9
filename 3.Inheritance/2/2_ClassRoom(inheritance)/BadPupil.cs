using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ClassRoom_inheritance_
{
    class BadPupil:Pupil
    {
        public BadPupil(string name) : base(name)
        {

        }

        public override void Write()
        {
            Console.WriteLine("{0} пишет неряшливо и с ошибками", Name);
        }

        public override void Read()
        {
            Console.WriteLine("{0} не любит читать", Name);
        }

        public override void Relax()
        {
            Console.WriteLine("{0} отдыхает, не сделав домашнее задание", Name);
        }

        public override void Study()
        {
            Console.WriteLine("{0} - плохой ученик", Name);
        }
    }
}
