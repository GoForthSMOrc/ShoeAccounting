using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeAccounting
{
    internal class OurShoeInfo
    {
        public static string Id { get; private set; }
        public static string DateReg { get; private set; }
        public static string DateComp { get; private set; }
        public static string StatusShoe { get; private set; }
        public static void InsertIntoOurShoeInfo(string[] args)
        {
            OurShoeInfo.Id = args[0];
            OurShoeInfo.DateReg = args[1];
            OurShoeInfo.DateComp = args[2];
            OurShoeInfo.StatusShoe = args[3];
        }

    }
}
