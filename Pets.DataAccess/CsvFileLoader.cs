using System.IO;

namespace Pets.DataAccess
{
    public class CsvFileLoader : ICsvFileLoader
    {
        private readonly string _filePath;

        public CsvFileLoader(string filePath)
        {
            _filePath = filePath;
        }

        public string LoadFile()
        {
            using (var reader = new StreamReader(_filePath))
                return reader.ReadToEnd();
        }
    }
}
