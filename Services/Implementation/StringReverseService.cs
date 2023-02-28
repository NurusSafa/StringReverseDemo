using StringReverseDemo.BLL.Implementation;
using StringReverseDemo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverseDemo.Services.Implementation
{
    public class StringReverseService:IStringReverseService
    {
        public StringReverseService()
        {
        }

        public string ReverseString(string value)
        {
            string strOutput = value.ToReverse();
            return strOutput;
        }

    }
}
