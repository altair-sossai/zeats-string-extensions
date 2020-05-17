namespace Zeats.StringExtensions
{
    public static class IsNullOrEmptyExtension
    {
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }
    }
}