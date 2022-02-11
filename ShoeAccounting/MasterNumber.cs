using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeAccounting
{
    internal class MasterNumber
    {
        public static int MasterNumbervalue { get; private set; }
        public static void InsertIntoMasterNumbervalue(int v)
        {
            MasterNumbervalue = v;
        }
    }
}
