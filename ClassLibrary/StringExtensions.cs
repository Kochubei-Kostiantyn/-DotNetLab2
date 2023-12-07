namespace ClassLibrary
{
    static class StringExtensions
    {
        public static string Reverse(this string s)
        {
            string result = "";
            foreach (char c in s)
                result += c;
            return result;
        }
        public static int Find(this string s, char C)
        {
            int result = 0;
            foreach (char c in s)
                if (c == C)
                    result++;
            return result;
        }
    }
}