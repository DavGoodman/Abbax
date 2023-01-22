
using Abbax;

Car car1 = new Car("NF123456", 147, 200, "green");
Console.WriteLine(car1.PrintInformation());

Car car2 = new Car("NF654321", 150, 195, "blue");
Console.WriteLine(car2.PrintInformation());

Console.WriteLine($"car1 and car2 are the same: {car1.Compare(car2)}\n");

Jet jet1 = new Jet("LN1234", 1000, 30, 2, 10);
Console.WriteLine(jet1.PrintInformation());

jet1.Run();
if(jet1.IsRunning) Console.WriteLine("Jet is flying, woosh\n");
car1.Run();
if (car1.IsRunning) Console.WriteLine("Car is driving, vroom vroom\n");

Boat boat1 = new Boat("ABC123", 100, 30, 500);
Console.WriteLine(boat1.PrintInformation());