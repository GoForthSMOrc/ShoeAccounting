using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeAccounting
{
    internal class ForMaster
    {
        public static string LName { get; private set; }
        public static string FName { get; private set; }
        public static string Patronymic { get; private set; }
        public static string Phone { get; private set; }
        public static string Email { get; private set; }
        public static void InsertIntoForMaster(string[] args)
        {
            ForMaster.LName = args[0];
            ForMaster.FName = args[1];
            ForMaster.Patronymic = args[2];
            ForMaster.Phone = args[3];
            ForMaster.Email = args[4];
        }
    }
}
