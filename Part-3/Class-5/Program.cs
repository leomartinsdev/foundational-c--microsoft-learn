// Adicioar lógica de ciclo ao código através das instruções do-while e while.

// As instruções do-while e while permitem-nos controlar o fluxo de execução de código ao executar um ciclo através de um bloco de código até que seja cumprida uma condição. Ao trabalhar com a instrução foreach, iteramos uma vez por cada item em sequência, 
// tal como uma matriz. A instrução for permite-nos iterar um número predefinido de vezes e controlar o processo de iteração. As instruções do-while e while permitem-nos iterar um bloco de código com a intenção de que a lógica dentro do bloco de código afete quando pudermos parar de iterar.
// A do-while instrução executa uma instrução ou um bloco de instruções enquanto uma expressão booleana especificada é avaliada como true. Dado que esta expressão é avaliada após cada execução do ciclo, um ciclo do-while é executado uma ou mais vezes.

/* Sintaxe
do
{
    // This code executes at least one time
} while (condição = true); -> se colocar true hard coded, entra em loop infinito.
*/

Random random = new Random();
int current = random.Next(1, 11);

/*
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");

// Usando o continue para causar um curto-circuito no resto do código.
do
{
    current = random.Next(1, 11);

    if (current >= 8) continue; // Se for >= 8, então eel pula para o while. Ou seja, o Console.WriteLine não será executado.

    Console.WriteLine(current);
} while (current != 7);


/*
Observação: do-while executa o código PELO MENOS uma vez.
While executa o código zero ou mais vezes.
*/

// Challenge - RPG Battle
int heroHP = 10;
int monsterHP = 10;

Random random2 = new Random();

while ((heroHP > 0) && (monsterHP > 0))
{
    int atkDamage = random2.Next(1, 11);
    monsterHP -= atkDamage;
    Console.WriteLine($"Monster took {atkDamage} damage. Monster has {monsterHP} HP left.");

    if (monsterHP > 0)
    {
        atkDamage = random2.Next(1, 11);
        heroHP -= atkDamage;
        Console.WriteLine($"Hero took {atkDamage} damage. Hero has {heroHP} HP left.");
    }
}

if (heroHP < 0 ) Console.WriteLine("Monster is the winner!");
else Console.WriteLine("Hero is the winner!");
