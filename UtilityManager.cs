using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InumentTestApp
{
    internal static class UtilityManager
    {
        /// <summary>
        /// A string extension method that converts string to a reversed string
        /// </summary>
        /// <param name="strInput">A string to act on.</param>
        /// <returns>  StrInput as a string.</returns>
        // <remarks> Nurus Safa Chowdhury, 2023-02-25.</remarks>
        internal static string ToReverse(this string strInput)
        {
            StringBuilder sbOutput = new StringBuilder();

            for (int i = strInput.Length-1; i >= 0; i--)
            {
                sbOutput.Append(strInput[i]);
            }
            strInput = sbOutput.ToString();
            return strInput;
        }

        /// <summary>
        ///    A string extension method that saves the string to a file.
        ///    It creates a new file or overwrite existing file.
        /// </summary>
        /// <param name="strTxt">A string to save</param>
        /// <param name="strFilePath">Full pathname of the file.</param>
        /// <returns></returns>
        // <remarks> Nurus Safa Chowdhury, 2023-02-25.</remarks>
        internal static async Task SaveToFile(this string strTxt,string strFilePath)
        {
           await File.WriteAllTextAsync(strFilePath, strTxt);            
        }
    }
}
