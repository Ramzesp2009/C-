using AutoLot.DAL.DataOperations;

InventoryDal getAllCar = new InventoryDal();
var cars = getAllCar.GetAllInventory();
foreach (var car in cars)
{
    Console.WriteLine($"-> CarId: {car.Id}, Make: {car.Make}, Color: {car.Color}, PetName: {car.PetName}");
}
//Console.WriteLine(cars);