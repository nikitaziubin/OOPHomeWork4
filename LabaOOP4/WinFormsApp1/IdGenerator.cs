namespace WinFormsApp1
{
    class IdGenerator
    {
        private static int currentId = 0;
        public static int getCurrentId()
        {
            return ++currentId;
        }
    }
}