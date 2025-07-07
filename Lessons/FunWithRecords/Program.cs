using FunWithRecords;

Console.WriteLine("********** RECORDS **********");
var myCarRecord = new CarRecord
{
    Make = "Honda",
    Model = "Pilot",
    Color = "Blue"
};
Console.WriteLine("My car: ");
DisplayCarRecordStats(myCarRecord);
Console.WriteLine();

CarRecord anotherMyCarRecord = new CarRecord("Honda", "Pilot", "Blue");
Console.WriteLine("Another variable for my car: ");
Console.WriteLine(anotherMyCarRecord.ToString());
Console.WriteLine();

static void DisplayCarRecordStats(CarRecord carRecord)
{
    Console.WriteLine($"Make: {carRecord.Make}, Model: {carRecord.Model}, Color: {carRecord.Color}");
}

Console.WriteLine($"Cars are the same? {myCarRecord.Equals(anotherMyCarRecord)}");
Console.WriteLine($"Cars are the same reference? {ReferenceEquals(myCarRecord, anotherMyCarRecord)}");
Console.WriteLine($"Cars are the same? {myCarRecord == anotherMyCarRecord}");
Console.WriteLine($"Cars are not the same? {myCarRecord != anotherMyCarRecord}");