string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}


// Inverter a ordem das paletes
Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}


// Utilizar métodos de matriz para limpar e redimensionar uma matriz
string[] pallets2 = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");


// -> Array.Clear(array, indice inicial, número de itens)
Array.Clear(pallets2, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets2.Length}");
foreach (var pallet in pallets2)
{
    Console.WriteLine($"-- {pallet}");
}


// Resize the array to add more elements
string[] pallets3 = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets3, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets3.Length}");
foreach (var pallet in pallets3)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
// -> Array.Resize(ref array, new number of elements)
Array.Resize(ref pallets3, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets3.Length}");

pallets3[4] = "C01";
pallets3[5] = "C02";

foreach (var pallet in pallets3)
{
    Console.WriteLine($"-- {pallet}");
}


// Use the ToCharArray() to reverse a string
// Reverse, then combine the char array into a new string
string value = "abc123";
char[] valueArray = value.ToCharArray(); // creates an array of char
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);


// Combine all of the chars into a new comma-separated-value string using Join()
string value2 = "abc123";
char[] valueArray2 = value2.ToCharArray();
Array.Reverse(valueArray2);
string result2 = string.Join(",", valueArray2); // Creates a string separating the items with ,
Console.WriteLine(result2);


// Split() the comma-separated-value string into an array of strings
string[] items = result2.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}


// Challenge 1
string pangram = "The quick brown fox jumps over the lazy dog";
string[] words = pangram.Split(" ");
string[] newArr = new string[words.Length];

for (int i = 0; i < words.Length; i++ )
{
    char[] charArray = words[i].ToCharArray();
    Array.Reverse(charArray);
    string reversedWord = string.Join("", charArray);
    newArr[i] = reversedWord;
}

string finalResult = string.Join(" ", newArr);
Console.WriteLine(finalResult);


// Challenge 2
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderArray = orderStream.Split(',');

for (int j = 0; j < orderArray.Length; j++)
{
    if (orderArray[j].Length != 4)
    {
        orderArray[j] = orderArray[j] + " - Error";
    }
}

foreach (string order in orderArray)
{
    Console.WriteLine(order);
}
