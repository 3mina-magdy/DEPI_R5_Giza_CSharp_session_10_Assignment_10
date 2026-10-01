using System;
using System.Collections.Generic;
using System.Text;

namespace session_10.Services
{
    public static class FirstNonRepeatedCharacter
    {
        public static int Find(string text)
        {
            Dictionary<char, int> frequencies =
                new Dictionary<char, int>();

            foreach (char character in text)
            {
                if (frequencies.ContainsKey(character))
                {
                    frequencies[character]++;
                }
                else
                {
                    frequencies[character] = 1;
                }
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (frequencies[text[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}