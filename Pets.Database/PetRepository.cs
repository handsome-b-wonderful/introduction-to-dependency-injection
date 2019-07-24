using System;
using System.Collections.Generic;
using Pets.Common;

namespace Pets.Database
{
    public class PetRepository
    {
        public static Pet Get(int id)
        {
            using (var db = DataFactory.DbFactory.GetDatabase())
                return db.SingleOrDefaultById<Pet>(id);
        }

        public static List<Pet> GetAll()
        {
            using (var db = DataFactory.DbFactory.GetDatabase())
                return db.Fetch<Pet>("");
        }
    }
}
