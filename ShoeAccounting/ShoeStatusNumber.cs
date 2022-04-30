namespace ShoeAccounting
{
    //Тянем статус ремонта обуви в окнах Добавления/Обновления записи.
    internal class ShoeStatusNumber
    {
        public static int ShoeStatusNumbervalue { get; private set; }
        public static void InsertIntoShoeStatusNumbervalue(int v)
        {
            ShoeStatusNumbervalue = v;
        }
    }
}
