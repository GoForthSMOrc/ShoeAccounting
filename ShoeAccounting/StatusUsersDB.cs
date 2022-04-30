namespace ShoeAccounting
{
    //Тянем статус пользователя в выпадающем списке в окне Добавления пользователя.
    internal class StatusUsersDB
    {
        public static int StatusUsersDBvalue { get; private set; }
        public static void InsertIntoStatusUsersDBvalue(int v)
        {
            StatusUsersDBvalue = v; 
        }
    }
}
