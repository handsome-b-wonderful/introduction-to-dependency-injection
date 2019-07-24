using System;
using System.Collections.Generic;
using System.Text;
using Pets.Common;
using Pets.Database;

namespace Pets.DataAccess
{
    public class SqlServerReader : IPetReader
    {
        public SqlServerReader(string connectionString)
        {
            DataFactory.Setup(connectionString);
        }

        public IEnumerable<Pet> GetPets()
        {
            return PetRepository.GetAll();
        }

        public Pet GetPet(int id)
        {
            return PetRepository.Get(id);
        }
    }
}
