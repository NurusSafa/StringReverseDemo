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
        readonly IDataRepository _dataRepo;
        public StringReverseService(IDataRepository dataRepo)
        {
            _dataRepo = dataRepo;
        }
        public async Task<string> GetReversedString(string strPath)
        {
            string data =  await _dataRepo.GetData(strPath);
            return data;
        }

        public string ReverseString(string value)
        {
            string strOutput = value.ToReverse();
            return strOutput;
        }

        public async Task SaveReversedString(string strValue, string strPath)
        {
            await _dataRepo.SaveData(strValue, strPath);
        }
    }
}
