// bool flag = true;

// if (flag)
// {
//     int value = 10;
//     Console.WriteLine($"Inside of code block: {value}");
// }

// Erro de compilação
//Console.WriteLine($"Outisde of code block: {value}");

bool flag = true;
int value = 0;

if (flag)
{
    value = 10;
    Console.WriteLine("Inside of code block: " + value);
}

Console.WriteLine($"Outside of code block: {value}");

string name = "steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");