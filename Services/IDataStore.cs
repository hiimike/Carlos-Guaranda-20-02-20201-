using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_BertoniSolutions.Services
{
    public interface IDataStore<T>
    {
        Task<T> GetItemAsync(string id);
        Task<IEnumerable<T>> GetItemsAsync();
    }
}
