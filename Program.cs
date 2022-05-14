using System;
using System.Linq;


namespace ConsoleApplication1
{
    class  Program
    {
        static void Main(string[] args)
        {
            ZeroAndOne("0101010100101010101001010101001010");

        }
        static public int ZeroAndOne(string s){
            return s.Replace("01","").Replace("10","").Length;

        }

    }

}