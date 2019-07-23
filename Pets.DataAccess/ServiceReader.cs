using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using Pets.Common;

namespace Pets.DataAccess
{
    public class ServiceReader : IPetReader
    {
        WebClient client = new WebClient();
        private string baseUri = "http://localhost:9874/api/pets";

        public IEnumerable<Pet> GetPets()
        {
            var result = client.DownloadString(baseUri);
            return JsonConvert.DeserializeObject<IEnumerable<Pet>>(result);
        }

        public Pet GetPet(int id)
        {
            var result = client.DownloadString($"{baseUri}/{id}");
            return JsonConvert.DeserializeObject<Pet>(result);
        }
    }
}
