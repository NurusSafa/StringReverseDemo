using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverseDemo.Services.Interfaces
{
    public interface IDataRepository
    {
        public Task<string> GetData(string strPath);
        public Task SaveData(string strValue, string strPath);
    }
}
