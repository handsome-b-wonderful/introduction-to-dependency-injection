using System.Collections.Generic;

namespace Pets.Common
{
    public interface IPetReader
    {
        IEnumerable<Pet> GetPets();
        Pet GetPet(int id);
    }
}
