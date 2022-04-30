namespace ShoeAccounting
{
    //Работа с нормером выбранной записи в главном меню
    internal class NumberCheck
    {
        public static string Number { get; private set; }
        public static void InsertIntoNumber(string N)
        {
            Number = N;
        }
    }
}
