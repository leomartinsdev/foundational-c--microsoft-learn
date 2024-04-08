string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);

string first_1 = "Hello";
string second_1 = "World";
Console.WriteLine("{1} {0}!", first_1, second_1);
Console.WriteLine("{0} {0} {0}!", first_1, second_1);

// String Interpolation
string primeiro = "Hello";
string segundo = "World";
Console.WriteLine($"{primeiro} {segundo}!");


// Formatting currency:
// :C presents the data as currency. The currency follows the user's country/region and language.
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// Formatting numbers:
// the :N specifier makes numbers more readable. -> :Nx, where X defines the number of digits after the decimal point.
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
Console.WriteLine($"Measurement: {measurement:N2} units");
Console.WriteLine($"Measurement: {measurement:N4} units");

// Formatting percentages:
// :Px formats as percentage, with x being the number of digits after the decimal point.
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

// Combining formatting approaches:
decimal price_2 = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price_2 - salePrice), price);
// or -> yourDiscount += $"A discount of {(price - salePrice)/price:P2}!";
Console.WriteLine(yourDiscount);

// Exercise - Explore string interpolation
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");

// Formatting strings by adding whitespace before or after:
// PadLeft(x, y) or PadRight(x) -> adds spaces so that the total number of chars equals X and can be filled with y
string input = "Pad this";
Console.WriteLine(input.PadLeft(12));
Console.WriteLine(input.PadRight(12, '-'));