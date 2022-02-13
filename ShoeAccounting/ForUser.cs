using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeAccounting
{
    internal class ForUser
    {
        public static string LName { get; private set; }
        public static string FName { get; private set; }
        public static string Patronymic { get; private set; }
        public static string Phone { get; private set; }
        public static string Email { get; private set; }
        public static void InsertIntoForUser(string[] args)
        {
            ForUser.LName = args[0];
            ForUser.FName = args[1];
            ForUser.Patronymic = args[2];
            ForUser.Phone = args[3];
            ForUser.Email = args[4];
        }
    }

}
