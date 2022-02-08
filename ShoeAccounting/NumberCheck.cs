using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeAccounting
{
    internal class NumberCheck
    {
        public static string Number { get; private set; }
        public static void InsertIntoNumber(string N)
        {
            Number = N;
        }
    }
}
