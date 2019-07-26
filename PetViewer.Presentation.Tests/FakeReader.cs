using System.Collections.Generic;
using System.Linq;
using Pets.Common;

namespace Pets.Presentation.Tests
{
    public class FakeReader : IPetReader
    {
        private List<Pet> data;

        public FakeReader()
        {
            data = new List<Pet>()
            {
                new Pet() { Id = 1, Age = 1, Category = "dog", Description = "World's cutest puppy", ImageUrl = "https://cdn.psychologytoday.com/sites/default/files/styles/image-article_inline_full/public/field_blog_entry_teaser_image/puppy_0.jpg?itok=z4JZm548", Name = "Roger", SerialNumber = "pye693"},
                new Pet() {Id = 2, Age=4, Category = "cat", Description = "Grumpy Cat", ImageUrl="https://i2.wp.com/metro.co.uk/wp-content/uploads/2019/05/SEI_70586560.jpg?quality=90&strip=all&zoom=1&resize=540%2C540&ssl=1", Name="Fudge", SerialNumber = "007"},

            };
        }

        public IEnumerable<Pet> GetPets()
        {
            return data;
        }

        public Pet GetPet(int id)
        {
            return data.FirstOrDefault(p => p.Id == id);
        }
    }
}
