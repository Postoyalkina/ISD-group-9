using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ClassRoom_inheritance_
{
    class Pupil
    {
        public string Name { get; set; }
        public Pupil(string name)
        {
            Name = name;
        }
        public virtual void Study()
        {
            Console.WriteLine("{0} учится", Name);
        }

        public virtual void Read()
        {
            Console.WriteLine("{0} читает", Name);
        }

        public virtual void Write()
        {
            Console.WriteLine("{0} пишет",Name);
        }

        public virtual void Relax()
        {
            Console.WriteLine("{0} отдыхает",Name);
        }

    }
}
