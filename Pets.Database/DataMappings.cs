using NPoco.FluentMappings;
using Pets.Common;

namespace Pets.Database
{
    public class DataMappings : Mappings
    {
        public DataMappings()
        {
            For<Pet>().Columns(x =>
            {
                x.Column(y => y.Id).WithName("id");
                x.Column(y => y.Name).WithName("name");
                x.Column(y => y.SerialNumber).WithName("serial");
                x.Column(y => y.Age).WithName("age");
                x.Column(y => y.Category).WithName("category");
                x.Column(y => y.Description).WithName("description");
                x.Column(y => y.ImageUrl).WithName("url");
            }).PrimaryKey("id", false);
        }
    }
}
