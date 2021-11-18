namespace wordslist
{
    public class Validation
    {
        public Validation()
        {
        }

        public static bool InvalidateString (string s)
        {
            return string.IsNullOrEmpty(s);
        }
    }
}
