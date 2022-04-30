namespace ShoeAccounting
{
    //Проверка используется ли элемент flowLayoutPanel (Используется это когда на панельку кликнули и она поменяла цвет на более темный)
    internal class CheckUsingElement
    {
        public static bool CheckUsing { get; private set; }
        public static void InsertIntoCheckUsingElement(bool Check)
        {
            CheckUsingElement.CheckUsing = Check;
        }
    }
}
