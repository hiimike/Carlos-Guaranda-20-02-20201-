using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Test_BertoniSolutions.Models;

namespace Test_BertoniSolutions.Services
{
    public class AlbumsDataStore : BaseDataStore, IDataStore<Album>
    {
        IEnumerable<Album> albums;

        public AlbumsDataStore()
        {
            albums = new List<Album>();
        }
        public async Task<IEnumerable<Album>> GetItemsAsync()
        {
       
            var json = await client.GetStringAsync($"albums");
            return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<Album>>(json));
          
           
        }

        public async Task<Album> GetItemAsync(string id)
        {
           
            var json = await client.GetStringAsync($"albums/{id}");
            return await Task.Run(() => JsonConvert.DeserializeObject<Album>(json));
         
        }
    }
}
