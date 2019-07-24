using System;
using System.Collections.Generic;
using System.Text;
using Pets.Common;

namespace Pets.DataAccess
{
    public class CachingReader : IPetReader
    {
        private const int cacheMinutes = 1;
        private IPetReader _baseReader;

        public CachingReader(IPetReader baseReader)
        {
            _baseReader = baseReader;
        }

        public IEnumerable<Pet> GetPets()
        {
            // we'll use -1 as the id for the entire collection
            return Caching.GetObjectFromCache(-1, cacheMinutes, _getAllPets);
        }

        public Pet GetPet(int id)
        {
            return Caching.GetObjectFromCache(id, cacheMinutes, _baseReader.GetPet);
        }

        // HACK: our cache expects the underlying retrieval method to take an id
        private IEnumerable<Pet> _getAllPets(int id)
        {
            return _baseReader.GetPets();
        }
    }
}
