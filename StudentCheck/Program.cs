
// REQUIREMENTS:
// Plan and build a Console Application that asks a user for their name and and their age.
// If their name is Bob or Sue, address them as Professor.
// If the person is under 21, recommend they wait X years to start this class.

//ask user for their name and age
Console.Write("What is your name: ");
string name = Console.ReadLine();
Console.Write("What is your age: ");
int.TryParse(Console.ReadLine(), out int age);

//determine how to address user
switch (name.ToLower())
{
    case "bob":
    case "sue":
        Console.Write("Welcome Professor! ");
        break;
    default:
        Console.Write($"Hello {name}. ");
        break;
}

//determine if the student can start class
if (age == 0)
{
    Console.WriteLine("You have not provided a correct age.");
}
else if (age < 21)
{
    Console.WriteLine($"You must wait {21 - age} years before you can start this class.");
}
else
{
    Console.WriteLine("You may begin this class.");
}
