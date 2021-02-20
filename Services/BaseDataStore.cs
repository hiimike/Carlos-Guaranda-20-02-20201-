using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Test_BertoniSolutions.Services
{
    public abstract class BaseDataStore
    {
        protected HttpClient client;

        public BaseDataStore() {
            client = new HttpClient();
            client.BaseAddress = new Uri($"https://jsonplaceholder.typicode.com/");
        }
    }
}
