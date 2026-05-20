using System;
using System.Collections.Generic;
using System.Text;

namespace To_do_list
{
    internal class Validator
    {
        public static bool IsValid(string text)
        {
            return !string.IsNullOrEmpty(text) && text.Length <= 100;
        }

    }
}
