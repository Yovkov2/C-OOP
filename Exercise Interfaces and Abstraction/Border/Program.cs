List<IBirthDate> society = new();

while (true)
{
    string input = Console.ReadLine();

    if (input == "End")
    {
        break;
    }

    string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string command = tokens[0];

    switch (command)
    {
        case "Citizen":
            IBirthDate citizen = new Citizen(tokens[3], tokens[1], int.Parse(tokens[2]), tokens[4]);
            society.Add(citizen);
            break;
        case "Pet":
            IBirthDate pet = new Pet(tokens[1], tokens[2]);
            society.Add(pet);
            break;
    }
}

string year = Console.ReadLine();

foreach (var element in society)
{
    if (element.BirthDate.EndsWith(year))
    {
        Console.WriteLine(element.BirthDate);
    }
}