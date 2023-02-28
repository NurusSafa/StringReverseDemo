using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverseDemo.BLL.Implementation
{
    internal static class StringReverseHelper
    {
        /// <summary>
        /// A string extension method that converts string to a reversed string
        /// </summary>
        /// <param name="strInput">A string to act on.</param>
        /// <returns>  StrInput as a string.</returns>
        // <remarks> Nurus Safa Chowdhury, 2023-02-25.</remarks>
        internal static string ToReverse(this string strInput)
        {
            if(!string.IsNullOrEmpty(strInput))
            {
                StringBuilder sbOutput = new StringBuilder();

                for (int i = strInput.Length - 1; i >= 0; i--)
                {
                    sbOutput.Append(strInput[i]);
                }
                strInput = sbOutput.ToString();               
            }
            return strInput;
        }
    }
}
