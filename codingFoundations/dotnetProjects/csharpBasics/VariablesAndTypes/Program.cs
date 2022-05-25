// This is an example of a single line comment

/* 
    This
    Is
    A
    Multi
    Line
    Comment
*/

/// This is an XML comment (3 forward slashes)
/// <para> This shows an XML comment </para>

// * NUMBERS in C#
// ! "VALUE" types
// - "int"
// type variableName = value;
int age = 45;

// - "long"
long longNum = 230949028849;

// * FOR NUMBERS W/ DECIMALS
// - "decimal"
decimal bankAccount = -45.25m;

// - "float"
float floatingNum = 2.3333333f;

// - "double"
// don't have to worry about a "suffix"
double doubleNum = 3.1415927;

// * BOOLEAN types
// - "bool"
// ! THIS IS A DECLARED VARIABLE
bool isDeclared;

// ! THIS VARIABLE HAS NOW BEEN INITIALIZED
isDeclared = true;

// * STRING data type
// - "string"
// - HAVE TO USE DOUBLE QUOTES " "
// - TECHNICALLY a "collection" of "char"
string greetingMessage = "Welcome to C#";

// - "char"
char space = ' ';
char hash = '#';
char letterA = 'A';
char letterZ = 'z';

// * ".." in a C# "collection" represents "everything" for INDEX RANGES
System.Console.WriteLine(greetingMessage[..]);
// expected: "Welcome to C#"
// * "everything" before
// System.Console.WriteLine(greetingMessage[..6]);
// expected: "Welcome"

// * "everything" after
System.Console.WriteLine(greetingMessage[11..]);
// expected: "C#"

// ! STRING MANIPULATION in C# example:
// * "\n" is a symbol representing a "new line" in the string
// * "{0}" represents FIRST argument after string in following example
System.Console.WriteLine("Your grade: {0}\nYour age: {1}", letterA, age);

// ! "REFERENCE" types
// * "string" is considered a reference type since it is TECHNICALLY a "collection" of "char" types
// * ARRAYS
/*
    1: specify TYPE of value being stored in array with []
    2: name for variable (array)
    3: values stored in array. HELD IN CURLY BRACES {}. separated by commas
*/
// 1        2       3
string[] names = { "TJ", "Rob", "Marco", "Kanye" };
//                  index start a 0
names[1] = "Drake";

System.Console.WriteLine(names[1]);
// expected: Drake

// * LISTS
// - list is a prebuilt CLASS within "System.Collections.Generic" namespace
/*
    1: specifying the type as a List class "collection" that can only store "char" data types
    2: naming the List<>
    3: using "new" keyword to create a new instance of (instantiate) a C# List<char> class
    4: inside curly braces, add new values for indexes in List<> "collection"
*/
// 1        2               3
List<char> listOfChars = new List<char>()
{
    // 4
    'x',
    '2',
    'w'
};

// how to ADD elements to a List<>
listOfChars.Add('$');

// ! STRING INTERPOLATION below
string listExOutput = $"listOfChars length: {listOfChars.Count}";
System.Console.WriteLine(listExOutput);
// expected: listOfChars length: 4