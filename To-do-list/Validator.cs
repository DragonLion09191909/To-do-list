using System;
using System.Collections.Generic;
using System.Text;

namespace To_do_list
{
    internal class Validator
    {
        public static bool Check(string text)=> text.Length > 100 || string.IsNullOrEmpty(text) ? false : true;

    }
}
