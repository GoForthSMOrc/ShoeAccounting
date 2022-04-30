namespace ShoeAccounting
{
    //Попытка обновления списка при удалении записи(MainMenu).Там закоменнтировал -> не работает этот класс получается.
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
