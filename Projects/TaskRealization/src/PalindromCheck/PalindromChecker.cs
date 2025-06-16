using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromCheck
{
    internal class PalindromChecker
    {
        public bool CheckPalindrom(string value)
        {
            for (int i = 0; i < value.Length / 2; i++)
            {
                if (value[i] != value[value.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckPalindrom(int value)
        {
            return true;
        }

        //public bool CheckPalindrom(int value1) // не работает !!!!
        //{
        //    return true;
        //}

        public bool CheckPalindrom(string value, string[] massive)
        {
            return true;
        }

        public override string ToString() //Переопределение, не путать с перегрузкой !!
        {
            return "Moscow";
        }
    }
}
