// * "=" is ASSIGNMENT OPERATOR
int a = 21;
int b = 300;

// * ADDITION "+" OPERATOR
int sum = a + b;

// * SUBTRACTION "-" OPERATOR
int difference = a - b;

// * MULTIPLICATION "*" OPERATOR
int product = a * b;

// * DIVISION "/" OPERATOR
// with "int" data type will not account for decimals in result of equation,
// will round DOWN to nearest whole "int" number
int quotient = a / b;

// * REMAINDER "%" OPERATOR (MODULUS)
// MODULUS "%" CHECKS HOW MANY TIMES SECOND NUMBER WILL GO INTO FIRST NUMBER, 
// AND RETURN THE REMAINDER
int remainder = b % a;

// * certain "structs" (other reference data types) can also use "operators"
DateTime today = DateTime.UtcNow;
System.Console.WriteLine($"Current Date: {today}");
// new DateTime(year, month, day)
DateTime someDay = new DateTime(2000, 1, 1);
// "TimeSpan" will be returned unformatted, need to find method for formatting date.
TimeSpan y2kTimeSpan = today - someDay;

System.Console.WriteLine("Addition result: {0}\n" +
"Subtraction result: {1}\n" +
"Multiplication result: {2}\n" +
"Division result: {3}\n" +
"Remainder result: {4}\n" +
"Time passed since y2k: {5}", sum, difference, product, quotient, remainder, y2kTimeSpan);

/*
    calculate how many miles the car will travel given mph and time travelling:
*/
int milesPerHour = 50;
decimal timeTravelled = 4.23m;

// how many miles will they travel?
decimal milesTravelled = milesPerHour * timeTravelled;

// ! TYPE CONVERSION
// * ".Parse()" for "string" -> "int"/"int" -> "string"
// dataTypeToConvertInto.Parse(variableToBeConverted)
// * ".ToInt32()" for "decimal" -> "int"
System.Console.WriteLine($"\nMiles Travelled: {decimal.ToInt32(milesTravelled)}");


// ! COMPARISON OPERATORS
// * EQUALS "==". WILL THROW ERROR IF USED FOR COMPARING DIFFERENT DATA TYPES
int age = 32;
string name = "TJ";

bool isEqual = age == 21;
// expected: False
bool userIsTJ = name == "TJ";
// expected: True

// * INEQUALITY "!="
bool isNotEqual = age != 21;
// expected: True

// * EQUALITY IN REFERENCE TYPES
// ! "new" instances of "reference" types ARE NOT EQUAL.
// ! considered two separate INSTANCES of "reference" type.
// ... variable "name" initialized on line 56
List<string> firstList = new List<string>();
firstList.Add(name);

List<string> secondList = new List<string>();
secondList.Add(name);

bool isReferenceTypeEqual = firstList == secondList;
// expected: False

// * GREATER THAN/LESS THAN/GREATER THAN OR EQUAL TO/LESS THAN OR EQUAL TO
/*
    greater than: >
    less than: <
    greater than or equal to: >=
    less than or equal to: <=
*/
// ... variable "age" initialized on line 55
bool greaterThan = age > 90;
// expected: False
bool lessThan = age < 90;
// expected: True
bool greaterThanOrEqual = age >= 90;
// expected: False
bool lessThanOrEqual = age <= 90;
// expected: True

// * AND (&&)/OR (||)
bool trueValue = true;
bool falseValue = false;

// * AND (&&)
// always FALSE unless both comparisons are TRUE
bool tAndT = trueValue && trueValue;
// expected: True
bool tAndF = trueValue && falseValue;
// expected: False
bool fAndT = falseValue && trueValue;
// expected: False
bool fAndF = falseValue && falseValue;
// expected: False

// * OR (||)
// always TRUE unless both comparisons are FALSE
bool tOrT = trueValue || trueValue;
// expected: True
bool tOrF = trueValue || falseValue;
// expected: True
bool fOrT = falseValue || trueValue;
// expected: True
bool fOrF = falseValue || falseValue;
// expected: False

System.Console.WriteLine($"age == 21: {isEqual}\n" +
$"name == 'TJ': {userIsTJ}\n" +
$"age != 21: {isNotEqual}\n" +
$"firstList == secondList: {isReferenceTypeEqual}\n" +
$"age > 90: {greaterThan}\n" +
$"age < 90: {lessThan}\n" +
$"age >= 90: {greaterThanOrEqual}\n" +
$"age <= 90: {lessThanOrEqual}\n" +
$"t && T: {tAndT}, t && F: {tAndF}, f && T: {fAndT}, f && F: {fAndF}\n" +
$"t || T: {tOrT}, t || F: {tOrF}, f || T: {fOrT}, f || F: {fOrF}");
