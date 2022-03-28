using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeAccounting
{
    internal class CheckUsingElement
    {
        public static bool CheckUsing { get; private set; }
        public static void InsertIntoCheckUsingElement(bool Check)
        {
            CheckUsingElement.CheckUsing = Check;
        }
    }
}
