using InumentTestApp;
using StringReverseDemo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverseDemo.Services.Implementation
{
    public class DataRepository : IDataRepository
    {
        public DataRepository()
        {

        }
        public async Task<string> GetData(string strPath)
        {
            if(!string.IsNullOrEmpty(strPath))
            {
                string data = await File.ReadAllTextAsync(strPath);
                return data;
            }
            return null;
        }

        public async Task SaveData(string strValue, string strPath)
        {
            await strValue.SaveToFile(strPath);
        }
    }
}
