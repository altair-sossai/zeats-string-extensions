using System;
using System.Text.RegularExpressions;

namespace Zeats.StringExtensions
{
    public static class SlugExtension
    {
        public static string Slug(this string text, int maxLength)
        {
            if (maxLength <= 0)
                throw new ArgumentOutOfRangeException(nameof(maxLength));

            if (text.IsNullOrEmpty())
                return text;

            var slug = text.RemoveDiacritics().ToLower();
            slug = Regex.Replace(slug, @"[^a-z0-9\s-]", "");
            slug = Regex.Replace(slug, @"\s+", " ").Trim();
            slug = slug.Substring(0, slug.Length <= maxLength ? slug.Length : maxLength).Trim();
            slug = Regex.Replace(slug, @"\s", "-");

            return slug;
        }
    }
}