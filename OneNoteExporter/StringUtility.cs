using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OneNoteExporter
{
    public static class StringUtility
    {
        public static string GenerateCharacters(int length, Random random)
        {
            const string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var result = new StringBuilder(length);
            for (var i = 0; i < length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]);
            }
            return result.ToString();
        }


        public static string GetSafeFilename(this string str)
        {

            return string.Join("_", str.Split(Path.GetInvalidFileNameChars()));

        }

    }
}
