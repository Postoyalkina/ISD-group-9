using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "txtFile.txt";
            string text = "Hiiiiii!!!!!!!!";
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            try
            {
                
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                    sw.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {

                using (StreamReader sw = new StreamReader(path, System.Text.Encoding.Default))
                {
                    Console.WriteLine(sw.ReadLine());
                    sw.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
