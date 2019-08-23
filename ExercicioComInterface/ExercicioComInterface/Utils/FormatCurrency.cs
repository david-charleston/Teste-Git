namespace Utils
{
    static class FormatCurrency
    {
        public static string Format(double value)
        {
            return string.Format("{0:c2}", value);
        }
    }
}
