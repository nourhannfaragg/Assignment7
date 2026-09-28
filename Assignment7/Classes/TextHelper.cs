using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment7.Classes
{
    public static class TextHelper
    {
        public static bool IsShorterThan(this string text ,int length)
        {
            if (text?.Length < length) return true;

            return false;
        }
        public static void Repeat(this string text, int items)
        {
            for (int i = 1; i <= items; i++)
            {
                Console.Write(text + " ");
            }
        }
        
    }
}
