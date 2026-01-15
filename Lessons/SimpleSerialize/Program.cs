using SimpleSerialize;
using System.Xml.Serialization;

Console.WriteLine("***** Fun with Object Serialization *****\n");


JamesBondCar jbc = new()
{
    CanFly = true,
    CanSubmerge = false,
    TheRadio = new()
    {
        StationPresets = new() { 89.3, 105.1, 97.1 },
        HasTweeters = true
    }
};

Person p = new()
{
    FirstName = "James",
    IsAlive = true
};

static void SaveAsXmlFormat<T>(T objGrapg, string fileName)
{
    XmlSerializer xmlFormat = new XmlSerializer(typeof(T));
    using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
    {
        xmlFormat.Serialize(fStream, objGrapg);
    }
}

SaveAsXmlFormat(jbc, "CarDate.xml");
Console.WriteLine("=> Saved car in XML format!");

SaveAsXmlFormat(p, "PersonData.xml");
Console.WriteLine("=> Saved person in XML format!");

static void SaveListOfCarsAsXml()
{
    List<JamesBondCar> myCars = new()
    {
        new JamesBondCar{CanFly = true, CanSubmerge = true},
        new JamesBondCar{CanFly = false, CanSubmerge = true},
        new JamesBondCar{CanFly = true, CanSubmerge = false},
        new JamesBondCar{CanFly = false, CanSubmerge = false },
    };
    using (Stream fStream = new FileStream("CarCollection.xml",
        FileMode.Create, FileAccess.Write, FileShare.None))
    {
        XmlSerializer xmlFormat = new XmlSerializer(typeof(List<JamesBondCar>));
        xmlFormat.Serialize(fStream, myCars);
    }
    Console.WriteLine("=> Saved list of cars!");
}

SaveListOfCarsAsXml();

static T ReadAsXmlFormat<T>(string fileName)
{
    XmlSerializer xmlFormat = new XmlSerializer(typeof(T));
    using (Stream fStream = new FileStream(fileName, FileMode.Open))
    {
        T obj = default;
        obj = (T)xmlFormat.Deserialize(fStream);
        return obj;
    }
}

JamesBondCar savedCar = ReadAsXmlFormat<JamesBondCar>("CarDate.xml");
Console.WriteLine($"Original Car: {savedCar.ToString()}");
Console.WriteLine($"Read Car: {savedCar.ToString()}");
List<JamesBondCar> savedCars = ReadAsXmlFormat<List<JamesBondCar>>("CarCollection.xml");

static void SaveAsJsonFormat<T>(T objGraph, string fileName)
{
    File.WriteAllText(fileName, System.Text.Json.JsonSerializer.Serialize(objGraph));
}

SaveAsJsonFormat(jbc, "CarDate.json");
Console.WriteLine("=> Saved car in JSON format!");

SaveAsJsonFormat(p, "PersonDate.json");
Console.WriteLine("=> Saved person in JSON format!");
