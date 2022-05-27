using Classes;

// "Console.WriteLine()" is considered a STATIC METHOD within the "Console" class
System.Console.WriteLine("----- PERSON/VEHICLE CLASS EXAMPLES -----");
Vehicle charger = new Vehicle();
Vehicle malibu = new Vehicle();
Vehicle spaceX = new Vehicle();
Vehicle unknown = new Vehicle();

// "setting" properties in class
charger.Make = "Dodge";
charger.Model = "Charger";
charger.Year = 2022;
charger.Mileage = 40040;
charger.TypeOfVehicle = VehicleType.Car;

malibu.Make = "Chevy";
malibu.Model = "Malibu";
malibu.Year = 2008;
malibu.Mileage = 100000;

spaceX.Make = "SpaceX";
spaceX.Model = "Rocket";
spaceX.Year = 2021;
spaceX.Mileage = 123495882.23;
spaceX.TypeOfVehicle = VehicleType.Spaceship;

Vehicle[] arrayOfVehicles = { charger, malibu, spaceX, unknown };

foreach (Vehicle vehicle in arrayOfVehicles)
{
    if (vehicle.TypeOfVehicle == VehicleType.Car)
    {
        System.Console.WriteLine($"You found a {vehicle.TypeOfVehicle}! " +
        $"This is a {vehicle.Year} {vehicle.Make} {vehicle.Model} with {vehicle.Mileage} miles.");
    }
}

System.Console.WriteLine($"I drive a {charger.Year} {charger.Make} {charger.Model} with {charger.Mileage} miles\n" +
    $"You drive a {malibu.Year} {malibu.Make} {malibu.Model}");

// ! PERSON EXAMPLE
Person person = new Person();

person.FirstName = "TJ";
person.LastName = "Hindman";
// new DateTime(year, month, day)
person.DateOfBirth = new DateTime(1990, 1, 10);
person.Transport = spaceX;

// * PERSON W/ CONSTRUCTOR EXAMPLE
Person chiefKeef = new Person("Chief", "Keef", new DateTime(1722, 5, 25), charger);

System.Console.WriteLine($"\nDamn {person.FirstName}! You're {person.Age} years old?!" +
    $"\nAt least you drive a {person.Transport.Make} {person.Transport.Model}");

System.Console.WriteLine($"This is {chiefKeef.FullName}. He's {chiefKeef.Age} years old and drives a {chiefKeef.Transport.Model}. What a legend.");


// ! Greeter.cs/Calculator.cs CLASS EXAMPLE
System.Console.WriteLine("\n----- GREETER CLASS EXAMPLE -----");
Greeter greeter = new Greeter();

greeter.SayHello("Mary");
greeter.SayHello();

System.Console.WriteLine("\n----- CALCULATOR CLASS EXAMPLE -----");
Calculator calcEx = new Calculator();

System.Console.WriteLine($".Add() Calculator method result: {calcEx.Add(13, 8)}");
System.Console.WriteLine($".Subtract() Calculator method result: {calcEx.Subtract(13, 8)}");
System.Console.WriteLine($".Multiply() Calculator method result: {calcEx.Multiply(13, 8)}");
System.Console.WriteLine($".Divide() Calculator method result: {calcEx.Divide(13, 8)}");
System.Console.WriteLine($".Remainder() Calculator method result: {calcEx.Remainder(16, 8)}");

// * STATIC METHOD TEST (USING ORIGINAL CLASS RATHER THAN AN "INSTANCE" OF THE CLASS)
System.Console.WriteLine($"Calculator.GetRandomNum() Calculator method result: {Calculator.GetRandomNum(300)}");

// * "namespace" is triggered when variable is associated with an "Access modifier"
// are assumed by code to exist WITHOUT needing to specify "namespace"

// class = "noun"
public class Vehicle
{
    // properties = "adjectives"
    /*
        1: access modifier => where can property be seen?
        2: type => type that the property can hold
        3: name => name of property. SHOULD BE PASCAL CASED (start with capitol letter)
        4: getters/setters =>
    */
    // * "?" = possibly null (nullable) value
    // 1    2       3       4
    public string Make { get; set; } = "Unknown manufacturer";
    public string Model { get; set; } = "Unknown model";
    public int Year { get; set; } = 2000;
    // if no initial value specified, will default to 0 for "double"
    public double Mileage { get; set; }
    // if no initial value specified, will default to first index for "enum"
    public VehicleType TypeOfVehicle { get; set; }
}

// ! ENUM (can be used for declaring types and associating predefined values to a CLASS property)
public enum VehicleType { Car, Truck, Van = 5, Motorcycle, Spaceship }


public class Person
{
    public string FirstName { get; set; }
    // every class "property" has an assumed "private" property associated with it
    // * "private" properties have no "get"/"set"
    private string _lastName;
    public string LastName
    {
        get
        {
            return _lastName;
        }
        set
        {
            _lastName = value;
        }
    }
    // * READONLY CLASS PROPERTY
    public string FullName
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
    }
    public DateTime DateOfBirth { get; set; }
    // * READONLY CLASS PROPERTY
    public int Age
    {
        get
        {
            // ! CUSTOM "GETTER"
            // calculating "Age" property of "Person" class instance based on "DateOfBirth" property
            TimeSpan exactAge = DateTime.Now - DateOfBirth;
            // can find total days passed associated with "TimeSpan" result through ".TotalDays"
            double totalDays = exactAge.TotalDays;
            // amountOfDaysPassed / 365.24 = amountOfYearsPassedUnrounded
            // * parenthesis () before variable represents shorthand "type conversion"
            double yearsUnrounded = totalDays / 365.24;

            int years = (int)Math.Round(yearsUnrounded);
            return years;
        }
    }

    public Vehicle Transport { get; set; }

    // ! CONSTRUCTORS IN CLASSES
    // * DEFAULT CONSTRUCTOR
    public Person() { }

    // * PARAMETERIZED CONSTRUCTOR
    public Person(string first, string last, DateTime dob, Vehicle vehicle)
    {
        FirstName = first;
        LastName = last;
        DateOfBirth = dob;
        Transport = vehicle;
    }
}
