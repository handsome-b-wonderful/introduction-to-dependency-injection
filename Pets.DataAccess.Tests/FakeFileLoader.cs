
namespace Pets.DataAccess.Tests
{
    public class FakeFileLoader : ICsvFileLoader
    {
        public enum  DataQuality
        {
            Good, Bad, Mixed, Empty
        }

        private DataQuality quality;

        public FakeFileLoader(DataQuality dataQuality)
        {
            quality = dataQuality;
        }

        public string LoadFile()
        {
            switch (quality)
            {
                case DataQuality.Empty:
                    return string.Empty;
                case DataQuality.Bad:
                    return CsvTestData.BadData;
                case DataQuality.Mixed:
                    return CsvTestData.MixedData;
                default: // DataQuality.Good
                    return CsvTestData.GoodData;
            }
        }
    }
}
