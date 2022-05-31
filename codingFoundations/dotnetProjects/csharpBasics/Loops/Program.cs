// ! FOR LOOPS
string[] students = { "Zach", "Mary", "Nick", "Kevin", "Hassan" };

// "i++" is shorthand for "i = i + 1"
for (int i = 0; i < students.Length; i++)
{
    System.Console.WriteLine($"good to see you {students[i]}");
}


// ! FOREACH LOOP
foreach (string student in students)
{
    System.Console.WriteLine($"foreach says what's up {student}");
}


// ! WHILE LOOP
// checks condition FIRST, executes code as long as condition is "true"
List<string> items = new List<string>();

while (items.Count < 4)
{
    items.Add($"Item {items.Count + 1}");
    System.Console.WriteLine($"{items.Last()}");
}


// ! DO WHILE LOOP
// executes AT LEAST ONCE before checking "while" condition.
// only checks condition after first execution.
do
{
    System.Console.WriteLine("this do/while condition is false!");
}
while (false);

// * difference between "do/while" and "while"
while (false)
{
    System.Console.WriteLine("this is a while condition that's false!");
}