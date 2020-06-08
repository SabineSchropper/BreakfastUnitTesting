using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Breakfast
{
    public static class Extension
    {
        public static string Print(this Array array)
        {
            string outputString = array.Length + " eggs";
            return outputString;

        }
    }
}
