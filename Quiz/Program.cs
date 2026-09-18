int points = 0;
Console.WriteLine("");

// -----------------------------------------------------------------------------

Console.WriteLine("1: Vilken sjukdom får Walter White?");
Console.WriteLine("a) Malaria");
Console.WriteLine("b) Hjärtsjukdom");
Console.WriteLine("c) Lungcancer");

string answer1 = Console.ReadLine();

if (answer1 == "c")
{
    points++;
    Console.WriteLine("CORRECT!");
}
else
{
    Console.WriteLine("INCORRECT!");
}

// -----------------------------------------------------------------------------

Console.WriteLine();
Console.WriteLine("2: Vad heter Walters partner?");
Console.WriteLine("a) Jesse Pinkman");
Console.WriteLine("b) Saul Goodman");
Console.WriteLine("c) Hank Schrader");

string answer2 = Console.ReadLine();

if (answer2 == "a")
{
    points++;
    Console.WriteLine("CORRECT!");
}
else
{
    Console.WriteLine("INCORRECT!");
}

// -----------------------------------------------------------------------------

Console.WriteLine();
Console.WriteLine("3: Vad kallar sig Walter White som kriminell?");
Console.WriteLine("a) Heisenberg");
Console.WriteLine("b) Gustavo");
Console.WriteLine("c) Tuco");

string answer3 = Console.ReadLine();

if (answer3 == "a")
{
    points++;
    Console.WriteLine("CORRECT!");
}
else
{
    Console.WriteLine("INCORRECT!");
}

// -----------------------------------------------------------------------------



if (points == 0)
{
    Console.WriteLine("Du har alltså ingen koll alls!");
}
else if (points < 3)
{
    Console.WriteLine("OK, du har hyfsad koll - eller gissade rätt!");
}
else
{
    Console.WriteLine("GRATTIS! Du hade alla rätt!");
}

// -----------------------------------------------------------------------------

Console.WriteLine();
Console.WriteLine("Tryck på valfri tangent för att avsluta.");
Console.ReadKey();

