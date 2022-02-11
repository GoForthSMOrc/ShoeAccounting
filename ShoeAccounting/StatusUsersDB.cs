using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeAccounting
{
    internal class StatusUsersDB
    {
        public static int StatusUsersDBvalue { get; private set; }
        public static void InsertIntoStatusUsersDBvalue(int v)
        {
            StatusUsersDBvalue = v; 
        }
    }
}
