using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeAccounting
{
    internal class DeleteCheck
    {
        public static bool DeleteCheckMark { get; private set;}
        public static void ChangeDeleteCheckMarkTrue()
        {
            DeleteCheckMark = true;
        }

        public static void ChangeDeleteCheckMarkFalse()
        {
            DeleteCheckMark = false;
        }
        
    }
}
