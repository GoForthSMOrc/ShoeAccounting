namespace ShoeAccounting
{
    //Проверка, чтобы при удалении номер не оставался
    internal class ControlNUMBER
    {
        public static string CheckNum { get; private set; }
        public static void InsertIntoControlNUMBER(string Check)
        {
            ControlNUMBER.CheckNum = Check;
        }
    }
}
