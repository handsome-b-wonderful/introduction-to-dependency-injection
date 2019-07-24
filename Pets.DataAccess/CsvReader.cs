using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pets.Common;

namespace Pets.DataAccess
{
    public class CsvReader : IPetReader
    {
        public ICsvFileLoader FileLoader { get; set; }

        public CsvReader()
        {
            var filePath = AppDomain.CurrentDomain.BaseDirectory + "pets.csv";
            FileLoader = new CsvFileLoader(filePath);
        }

        public Pet GetPet(int id)
        {
            var pets = GetPets();
            return pets?.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Pet> GetPets()
        {
            var fileData = FileLoader.LoadFile();
            var pets = ParseData(fileData);
            return pets;
        }

        private IEnumerable<Pet> ParseData(string csvData)
        {
            var pets = new List<Pet>();
            var lines = csvData.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            foreach (var line in lines)
            {
                try
                {
                    pets.Add(ParsePetString(line));
                }
                catch (Exception)
                {
                    // TODO: log, skip bad record, continue
                }
            }
            return pets;
        }

        private Pet ParsePetString(string petData)
        {
            var elements = petData.Split(',');
            var pet = new Pet()
            {
                Id = int.Parse(elements[0]),
                Name = elements[1],
                SerialNumber = elements[2],
                Age = int.Parse(elements[3]),
                Category = elements[4],
                Description = elements[5],
                ImageUrl = elements[6]
            };
            return pet;
        }
    }
}
