using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_string_
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Summer is coming!";
            Console.WriteLine($"string = {a}\n");
            Console.WriteLine($"IndexOf('i') : \n origin : {a.IndexOf('i')}\n my funk: {a.myIndexOf('i')} \n");

            Console.WriteLine($"SubString(7) : \n origin : {a.Substring(7)}\n my funk: {a.mySubString(7)}\n");
            Console.WriteLine($"SubString(7,2) : \n origin : {a.Substring(7,2)}\n my funk: {a.mySubString(7,2)}\n");

            Console.WriteLine($"Replace('m','n') : \n origin : {a.Replace('m','n')}\n my funk: {a.myReplace('m','n')}\n");
            Console.WriteLine($"Replace(\"Summer\",\"Winter\") : \n origin : {a.Replace("Summer", "Winter")}\n my funk: {a.myReplace("Summer", "Winter")}");
            Console.ReadKey();

        }


    }
    public static class StringExtention
    {
        public static int myIndexOf(this string a, char b)
        {
            for (int i = 0; i < a.Length; i++)
                if (a[i] == b)
                    return i;
            return -1;
        }

        public static String mySubString(this string A, int startIndex)
        {
            return mySubString(A, startIndex, A.Length - startIndex);
        }
        public static String mySubString(this string A, int startIndex, int length)
        {
            string outer = "";
            for (int i = startIndex; i < startIndex + length; i++)
                outer += A[i];
            return outer;
        }

        public static String myReplace(this string A, char from, char to)
        {
            string outer = "";
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != from)
                    outer += A[i];
                else
                    outer += to;
            }
            return outer;
        }
        public static String myReplace(this string A, string from, string to)
        {
            string outer = A;
            while (outer.Contains(from))
            {
                int y = outer.IndexOf(from);
                outer = outer.Remove(y, from.Length);
                outer = outer.Insert(y,to);
            }
            return outer;
        }
    }

}
