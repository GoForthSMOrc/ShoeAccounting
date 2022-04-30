namespace ShoeAccounting
{
    /*Тянем номер мастера при смене значения в выпадающих списках окон Добавления/Обновления записи.
     * (Выглядит сомнительно. Можно наверно сделать, что значения тянулись с таблицы мастеров, а не писать их).
     */
    internal class MasterNumber
    {
        public static int MasterNumbervalue { get; private set; }
        public static void InsertIntoMasterNumbervalue(int v)
        {
            MasterNumbervalue = v;
        }
    }
}
