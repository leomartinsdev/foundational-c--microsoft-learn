// Iterar através da utilização de bloco de código para uma instrução em C#.

/*
A instrução for itera um bloco de código um determinado número de vezes. Esse nível de controle 
torna a for instrução única entre as outras instruções de iteração. A instrução foreach itera um 
bloco de código uma vez para cada item numa sequência de dados, como uma matriz ou uma coleção. 
A instrução while itera um bloco de código até que seja cumprida uma condição.
Além disso, a instrução for proporciona-lhe muito mais controlo sobre o processo de iteração ao 
expor as condições de iteração.
*/

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

/*
int i = 0 -> inicializador
i < 0 -> condição de conclusão
i ++ -> iterador
*/

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}

// break -> Serve para sair da instrução de iteração.

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

/* Limitação do foreach
string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{
    // Can't do this:
    if (name == "David") name = "Sammy";
}
*/

string[] nameArray = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < nameArray.Length; i++)
    if (nameArray[i] == "David") nameArray[i] = "Sammy";

/*
Ou:
string[] nameArray = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < nameArray.Length; i++)
{
    if (nameArray[i] == "David")
    {
        nameArray[i] = "Sammy";
    }
}
*/

foreach (var name in nameArray) Console.WriteLine(name);

// FizzBuzz Challenge
string message = "";

for (int i = 1; i < 100; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
    {
        message = "FizzBuzz";
    }
    else if (i % 3 == 0)
    {
        message = "Fizz";
    }
    else if (i % 5 == 0)
    {
        message = "Buzz";
    }
    else
        message = "";

    Console.WriteLine($"Número {i}: {message}");
}