using System;
using System.IO;
using System.Linq;
using Xunit;

namespace Pets.DataAccess.Tests
{
    public class CsvReaderTests
    {
        [Fact]
        public void GetPetsWithGoodRecordsReturnsAllRecords()
        {
            // arrange
            var reader = new CsvReader();
            reader.FileLoader = new FakeFileLoader(FakeFileLoader.DataQuality.Good);

            // act
            var pets = reader.GetPets();

            // assert
            Assert.Equal(2, pets.Count());
        }

        [Fact]
        public void GetPetsWithNoFileThrowsException()
        {
            var reader = new CsvReader();

            Assert.Throws<FileNotFoundException>(
                () => reader.GetPets());
        }

        [Fact]
        public void GetPetsWithMixedRecordsReturnsAllRecords()
        {
            var reader = new CsvReader();
            reader.FileLoader = new FakeFileLoader(FakeFileLoader.DataQuality.Mixed);

            var pets = reader.GetPets();

            Assert.Equal(2, pets.Count());
        }

        [Fact]
        public void GetPetsWithBadRecordsReturnsEmptyList()
        {
            var reader = new CsvReader();
            reader.FileLoader = new FakeFileLoader(FakeFileLoader.DataQuality.Bad);

            var pets = reader.GetPets();

            Assert.Empty(pets);
        }

        [Fact]
        public void GetPetsWithEmptyFileReturnsEmptyList()
        {
            var reader = new CsvReader();
            reader.FileLoader = new FakeFileLoader(FakeFileLoader.DataQuality.Empty);

            var pets = reader.GetPets();

            Assert.Empty(pets);
        }
    }
}
