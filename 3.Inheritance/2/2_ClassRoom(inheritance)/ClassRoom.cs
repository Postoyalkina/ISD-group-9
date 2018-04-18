using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ClassRoom_inheritance_
{
    class ClassRoom
    {
        Pupil[] pupils;
        public ClassRoom(Pupil pupil_1, Pupil pupil_2)
        {
            pupils = new Pupil[] { pupil_1, pupil_2};
        }

        public ClassRoom(Pupil pupil_1, Pupil pupil_2, Pupil pupil_3)
        {
            pupils = new Pupil[] { pupil_1, pupil_2, pupil_3};
        }

        public ClassRoom(Pupil pupil_1, Pupil pupil_2, Pupil pupil_3, Pupil pupil_4)
        {
            pupils = new Pupil[] { pupil_1, pupil_2, pupil_3, pupil_4};
        }

        public void Display()
        {
            foreach (Pupil item in pupils)
            {
                item.Study();
                item.Read();
                item.Write();
                item.Relax();
                Console.WriteLine("\n" + new string('#',40) + "\n");
            }
            
        }
    }
}
