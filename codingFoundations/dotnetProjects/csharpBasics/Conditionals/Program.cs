// ! IF/ELSE STATEMENTS
string instructorName = "Scooby Doo";

if (instructorName.Length <= 2)
{
    System.Console.WriteLine($"Good to see you {instructorName}");
}
else if (instructorName[0] == 'S')
{
    System.Console.WriteLine($"What's new {instructorName}");
}
else
{
    System.Console.WriteLine("I dont know you bro.");
}

// ! SWITCH CASES
string output;

switch (instructorName)
{
    case "TJ":
        output = $"What's up you";
        break;
    case "scooby doo":
        output = $"Do you want a scooby snack?";
        break;
    case "Scooby Doo":
        output = $"What's new {instructorName}";
        break;
    default:
        output = "I dont know you bro.";
        break;
}

// * ASSIGN "SWITCH CASE" TO A VARIABLE
string nameTwo = "TJ";

output = nameTwo switch
{
    "TJ" => $"What's up you",
    "scooby doo" => $"Do you want a scooby snack?",
    "Scooby Doo" => $"What's new {instructorName}",
    // "_" represents "default" case in current syntax
    _ => "I dont know you bro.",
};

System.Console.WriteLine(output);

// ! TERNARY STATEMENTS
int age = 50;

System.Console.WriteLine(age > 37 ? "Teach me wise one" : "can I call you by your first name?");
// Expected: "Teach me wise one"

string response = age <= 50 ? "pay attention to your 401k" : "enjoy the finer things in life";

System.Console.WriteLine(response);
// Expected: "pay attention to your 401k"
