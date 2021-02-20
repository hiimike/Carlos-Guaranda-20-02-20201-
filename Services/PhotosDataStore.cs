using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Test_BertoniSolutions.Models;

namespace Test_BertoniSolutions.Services
{
    public class PhotosDataStore : BaseDataStore , IDataStore<Photo>
    {
        IEnumerable<Photo> photos;

        public PhotosDataStore()
        {
            photos = new List<Photo>();
        }
        public async Task<IEnumerable<Photo>> GetItemsAsync()
        {

            var json = await client.GetStringAsync($"photos");
            return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<Photo>>(json));


        }

        public async Task<Photo> GetItemAsync(string id)
        {

            var json = await client.GetStringAsync($"photos/{id}");
            return await Task.Run(() => JsonConvert.DeserializeObject<Photo>(json));

        }
    }
}
