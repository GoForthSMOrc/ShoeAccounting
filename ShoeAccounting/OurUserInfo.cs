using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeAccounting
{
    internal class OurUserInfo
    {
        public static string id_UsersDBInfo { get; private set; }
        public static string LName { get; private set; }
        public static string FName { get; private set; }
        public static string Patronymic { get; private set; }
        public static string Phone { get; private set; }
        public static string Email { get; private set; }
        public static string StatusU { get; private set; }
        public static void InsertIntoOurUserInfo(string[] args)
        {
            OurUserInfo.LName = args[0];
            OurUserInfo.FName = args[1];
            OurUserInfo.Patronymic = args[2];
            OurUserInfo.Phone = args[3];
            OurUserInfo.Email = args[4];
            OurUserInfo.StatusU = args[5];
            OurUserInfo.id_UsersDBInfo = args[6];
        }
    }
}
