using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Test_BertoniSolutions.Models;

namespace Test_BertoniSolutions.Services
{
    public class CommentDataStore : BaseDataStore,  IDataStore<Comment>
    {
        IEnumerable<Comment> comments;

        public CommentDataStore()
        {
            comments = new List<Comment>();
        }
        public async Task<IEnumerable<Comment>> GetItemsAsync()
        {

            var json = await client.GetStringAsync($"comments");
            return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<Comment>>(json));


        }

        public async Task<Comment> GetItemAsync(string id)
        {

            var json = await client.GetStringAsync($"photos/{id}");
            return await Task.Run(() => JsonConvert.DeserializeObject<Comment>(json));

        }
    }
}
