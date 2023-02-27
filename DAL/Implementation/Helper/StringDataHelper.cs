using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverseDemo.DAL.Implementation.Helper
{
    internal static class StringDataHelper
    {        
        
        /// <summary>
       ///    A string extension method that saves the string to a file.
       ///    It creates a new file or overwrite existing file.
       /// </summary>
       /// <param name="strTxt">A string to save</param>
       /// <param name="strFilePath">Full pathname of the file.</param>
       /// <returns></returns>
        // <remarks> Nurus Safa Chowdhury, 2023-02-25.</remarks>
        internal static async Task SaveToFile(this string strTxt,  string strFilePath)
        {
            if(!string.IsNullOrEmpty(strTxt) && !string.IsNullOrEmpty(strFilePath))
            {
                await File.WriteAllTextAsync(strFilePath, strTxt);
            }
        }
    }
}
