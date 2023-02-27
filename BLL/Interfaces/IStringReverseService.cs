using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverseDemo.Services.Interfaces
{
    internal interface IStringReverseService
    {
        public string ReverseString(string value);
        public Task<string> GetReversedString(string strPath);
        public Task SaveReversedString(string strValue, string strPath);
    }
}
