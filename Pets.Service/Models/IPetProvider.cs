using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Common;

namespace Pets.Service.Models
{
    public interface IPetProvider
    {
        List<Pet> GetPets();
    }
}
