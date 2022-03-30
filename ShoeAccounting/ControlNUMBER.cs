using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeAccounting
{
    internal class ControlNUMBER
    {
        public static string CheckNum { get; private set; }
        public static void InsertIntoControlNUMBER(string Check)
        {
            ControlNUMBER.CheckNum = Check;
        }
    }
}
