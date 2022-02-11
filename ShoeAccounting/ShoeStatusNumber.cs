using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeAccounting
{
    internal class ShoeStatusNumber
    {
        public static int ShoeStatusNumbervalue { get; private set; }
        public static void InsertIntoShoeStatusNumbervalue(int v)
        {
            ShoeStatusNumbervalue = v;
        }
    }
}
