using System;

namespace Pets.DataAccess.Tests
{
    public class CsvTestData
    {
        public static string GoodData = "100,Oscar,90120,0,Dog,Black and Brown Puppy,https://images.pexels.com/photos/39317/chihuahua-dog-puppy-cute-39317.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500" + Environment.NewLine +
            "105,Waldorf,1231,12,Dog,Wrinkly Dog,https://media4.s-nbcnews.com/i/newscms/2016_52/1184388/rescue-group-old-dog-haven-today-161226-tease-01_00bac92f7fa6330b327ff47cdd4acdf2.jpg" + Environment.NewLine;

        public static string BadData = "BAD DATA" + Environment.NewLine + "MORE BAD DATA" + Environment.NewLine;

        public static string MixedData = "102,Finnegan,1239,2,Lizard,Yemenese Chameleon,https://upload.wikimedia.org/wikipedia/commons/6/68/Yemen_Chameleon.jpg" + Environment.NewLine +
            "INVALID" + Environment.NewLine +
            "104,Tracker,7363,1,Dog,Yellow Lab,https://tvar.org/wp-content/uploads/2018/04/iStock-486330501-copy.jpg" + Environment.NewLine +
            "ANOTHER INVALID" + Environment.NewLine;
    }
}
