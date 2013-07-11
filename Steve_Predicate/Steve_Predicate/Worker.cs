using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Steve_Predicate
{
    class Worker
    {
        public static bool IsEven(int i)
        {

            return ((i % 2) == 0);
        }


        public static bool IsLessThanTen(int i)
        {

            if (i < 10)
                return true;
            else
                return false;
        }
    }
}
