// ! INHERITANCE IN C#
Mammal platypus = new Mammal("Perry", 4, true, DietType.Omnivore, Size.Medium, true, "blue");
// BASE class properties
// platypus.Name = "Perry";
// platypus.NumLegs = 4;
// platypus.TypeOfDiet = DietType.Omnivore;
// platypus.SizeOfAnimal = Size.Medium;
// platypus.IsMammal = true;

// DERIVED class property
// platypus.FurColor = "blue";

System.Console.WriteLine($"This is a {platypus.Name}\n" + 
    // ! if using ternary statements in a template string, need parenthesis around ternary
    $"They have {platypus.NumLegs} legs and {(platypus.HasFur ? "do" : "do not")} have fur. Fur color is {platypus.FurColor}.\n" + 
    $"They are a {platypus.SizeOfAnimal} {platypus.TypeOfDiet}.\n" + 
    (platypus.IsMammal ? "This animal is a mammal." : "This animal is not a mammal."));
// DERIVED class method
platypus.MakeNoise("oof");

// * BASE class (parent class)
// "ABSTRACT" class: an instance cannot be made of the class, but can be used for INHERITANCE.
public abstract class Animal
{
    public Animal()
    {
        System.Console.WriteLine("this is the Animal constructor.");
    }

    public Animal(string name, int numLegs, bool hasFur, DietType typeOfDiet, Size sizeOfAnimal, bool isMammal)
    {
        Name = name;
        NumLegs = numLegs;
        HasFur = hasFur;
        TypeOfDiet = typeOfDiet;
        SizeOfAnimal = sizeOfAnimal;
        IsMammal = isMammal;
    }

    public string Name { get; set; }
    public int NumLegs { get; set; }
    public bool HasFur { get; set; }
    public DietType TypeOfDiet { get; set; }
    public Size SizeOfAnimal { get; set; }
    public bool IsMammal { get; set; }
}

// DietType
// want predefined values that DietType could be set as... best way would be with "enum"
public enum DietType { Herbivore, Carnivore, Omnivore }
public enum Size { Small, Medium, Large, ExtraLarge}

// * DERIVED class (child class)
public class Mammal : Animal
{
    public Mammal() : base()
    {
        System.Console.WriteLine("this is the Mammal constructor.");
    }

    // ! "base" keyword is essential in DERIVED (child) classes
    // properties belonging to "base" class need to be included in arguments for "base()" constructors
    public Mammal(string name, int numLegs, bool hasFur, DietType typeOfDiet, Size sizeOfAnimal, bool isMammal, string furColor) : base(name, numLegs, hasFur, typeOfDiet, sizeOfAnimal, isMammal)
    {
        FurColor = furColor;
    }

    public string FurColor { get; set; }
    public void MakeNoise(string sound)
    {
        System.Console.WriteLine($"{sound}! {sound}!");
    }
}