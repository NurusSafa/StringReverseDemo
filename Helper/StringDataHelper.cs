using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverseDemo.Helper
{
    internal static class StringDataHelper
    {
        /// <summary>
        /// Retrieve all the text asynchronously from file of specified path
        /// </summary>
        /// <param name="strPath"></param>
        /// <returns></returns>
        public static async Task<string> GetDataFromFile(string strPath)
        {
            if (!string.IsNullOrEmpty(strPath))
            {
                string data = await File.ReadAllTextAsync(strPath);
                return data;
            }
            return null;
        }
        /// <summary>
        ///    A string extension method that saves the string asynchronously to a file.
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
