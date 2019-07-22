using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Common;

namespace Pets.Service.Models
{
    public class StaticPetProvider : IPetProvider
    {
        public List<Pet> GetPets()
        {
            var pets = new List<Pet>()
            {
                new Pet(){Id = 1, Name = "Barney", Age=7, Category = "Dog", Description="Blue Tick Hound", SerialNumber = "3734534", ImageUrl ="https://upload.wikimedia.org/wikipedia/commons/d/d6/BluetickCoonhound.jpg" },
                new Pet(){Id = 2, Name = "Cynthia", Age=3, Category = "Cat", Description="Domestic Short Hair", SerialNumber = "364556", ImageUrl ="https://www.thehappycatsite.com/wp-content/uploads/2017/11/domestic-shorthair.jpg" },
                new Pet(){Id = 3, Name = "Crackers", Age=14, Category = "Bird", Description="Parrot", SerialNumber = "119119", ImageUrl ="https://lafeber.com/pet-birds/wp-content/uploads/YellowHeadAmazon-300x300.png" },
                new Pet(){Id = 4, Name = "Reggie", Age=1, Category = "Dog", Description="Golden Retriever", SerialNumber = "587215", ImageUrl ="https://dogtime.com/assets/uploads/2010/12/puppies.jpg" },
                new Pet(){Id = 5, Name = "Unknown", Age=0, Description="Mystery Creature" }

            };

            return pets;
        }
    }
}
