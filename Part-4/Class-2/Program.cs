int first = 2;
string second = "4";
// int result = first + second;
string result = first + second;
Console.WriteLine(result);


int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt; // widening conversion
Console.WriteLine($"decimal: {myDecimal}");

//When you know you're performing a widening conversion, you can rely on implicit conversion. The compiler handles implicit conversions.

decimal myDecimal2 = 3.14m;
Console.WriteLine($"decimal: {myDecimal2}");

int myInt2 = (int)myDecimal2; // cast. You perform an explicit conversion to the defined cast data type (int)
Console.WriteLine($"int: {myInt2}");

decimal myDecimal3 = 1.23456789m;
float myFloat = (float)myDecimal3;

Console.WriteLine($"Decimal: {myDecimal3}");
Console.WriteLine($"Float  : {myFloat}");

// Use ToString() to convert a number to a string
int primeiro = 5;
int segundo = 7;
string message = primeiro.ToString() + segundo.ToString();
Console.WriteLine(message);

// Convert a string to an int using the Parse() helper method -> type.Parse(value).
string first2 = "5";
string second2 = "7";
int sum = int.Parse(first2) + int.Parse(second2);
Console.WriteLine(sum);

// Convert a string to a int using the Convert class -> Convert.ToSomething(value).
string value1 = "5";
string value2 = "7";
int result2 = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result2);

// you used the Convert.ToInt32() method with a string here, but you should probably use TryParse() when possible.
// So, when should you use the Convert class? The Convert class is best for converting fractional numbers into whole numbers (int) because it rounds up the way you would expect.


// Compare casting and converting a decimal into an int
int value3 = (int)1.5m; // casting truncates
Console.WriteLine(value3);

int value4 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value4);


// -> Use TryParse()
// TryParse() a string into an int
string valueA = "102";
int resultA = 0;
if (int.TryParse(valueA, out resultA))
{
   Console.WriteLine($"Measurement: {resultA}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}

// Use the parsed int later in code
string valueB = "102";
int resultB = 0;
if (int.TryParse(valueB, out resultB))
{
   Console.WriteLine($"Measurement: {resultB}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + resultB}");

// What if it can't be converted?
string valueC = "bad";
int resultC = 0;
if (int.TryParse(valueC, out resultC))
{
   Console.WriteLine($"Measurement: {resultC}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}

if (resultC > 0) Console.WriteLine($"Measurement (w/ offset): {50 + resultC}");


// Challenge 1
string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string messageString = "";

foreach (var value in values)
{
    decimal number; // stores the TryParse "out" value
    if (decimal.TryParse(value, out number))
    {
        total += number;
    } else
    {
        messageString += value;
    }
}

Console.WriteLine($"Message: {messageString}");
Console.WriteLine($"Total: {total}");

// Challenge 2
int valueChal1 = 12;
decimal valueChal2 = 6.2m;
float valueChal3 = 4.3f;

// Your code here to set result1Challenge
// Hint: You need to round the result to nearest integer (don't just truncate)
int result1Challenge = Convert.ToInt32(valueChal1 / valueChal2);

Console.WriteLine($"Divide valueChal1 by valueChal2, display the result as an int: {result1Challenge}");

// Your code here to set result2Challenge
decimal result2Challenge = valueChal2 / Convert.ToDecimal(valueChal3); 
Console.WriteLine($"Divide valueChal2 by valueChal3, display the result as a decimal: {result2Challenge}");

// Your code here to set result3Challenge
float result3Challenge = valueChal3 / valueChal1;
Console.WriteLine($"Divide valueChal3 by valueChal1, display the result as a float: {result3Challenge}");