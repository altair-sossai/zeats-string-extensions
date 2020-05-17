using System.Globalization;
using System.Text;

namespace Zeats.StringExtensions
{
    public static class RemoveDiacriticsExtension
    {
        public static string RemoveDiacritics(this string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var value in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(value);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                    stringBuilder.Append(value);
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}