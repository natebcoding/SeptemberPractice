//Build a program that will show the menu illustrated above.
// [x] Ask the user to enter a number from the menu.
// [x] Using the information above, use a switch (either type) to show the item’s cost.

// Part 2 
// [x] Modify your program to also ask the user for their name
// [x] If the name equals your name, divide the cost in half



// VERSION 1

Console.WriteLine("What is your name?");
string name = Console.ReadLine();

Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("The following items are available: ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("What number do you want to see the price of? ");

int input = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.White;

switch (input)
{
    case 1:
        if (name == "Nate") { Console.WriteLine("The rope is 5 gold (50% Discount for you!)"); }
        else
            Console.WriteLine("The rope is 10 gold");
        break;
    case 2:
        if (name == "Nate") { Console.WriteLine("Torches are 8 gold each. (50% Discount for you!)"); }
        else
            Console.WriteLine("Torches are 16 gold each");
        break;
    case 3:
        if (name == "Nate") { Console.WriteLine("Climbing Equipment is 12 gold each (50% Discount for you!)"); }
        else
            Console.WriteLine("Climbing equipment is 24 gold each");
        break;
    case 4:
        if (name == "Nate") { Console.WriteLine("Clean water is 1 gold (50% Discount for you!)"); }
        else
            Console.WriteLine("Clean water is 2 gold.");
        break;
    case 5:
        if (name == "Nate") { Console.WriteLine("A machete is 10 gold (50% Discount for you!)"); }
        else
            Console.WriteLine("A machete is 20 gold.");
        break;
    case 6:
        if (name == "Nate") { Console.WriteLine("A canoe is 100 gold (50% Discount for you!)"); }
        else
            Console.WriteLine("A canoe is 200 gold.");
        break;
    case 7:
        if (name == "Nate") { Console.WriteLine("Food supplies are 1 gold each (50% Discount for you!)"); }
        else
            Console.WriteLine("Food supplies will be 2 gold each.");
        break;
    default:
        Console.WriteLine("Sorry, that's an invalid entry.");
        break;




// VERSION 2

Console.WriteLine("What is your name?");
string name = Console.ReadLine();

Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("The following items are available: ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("What number do you want to see the price of? ");

int ropePrice = 10;
int torchesPrice = 16;
int climbingEquipmentPrice = 24;
int cleanWaterPrice = 2;
int machetePrice = 20;
int canoePrice = 200;
int foodSuppliesPrice = 2;

int input = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.White;

switch (input)
{
    case 1:
        if (name == "Nate") { Console.WriteLine($"The rope is {ropePrice / 2} gold with your discount!"); }
        else
            Console.WriteLine($"The rope is {ropePrice} gold");
        break;
    case 2:
        if (name == "Nate") { Console.WriteLine($"Torches are {torchesPrice / 2} gold with your discount!"); }
        else
            Console.WriteLine($"Torches are {torchesPrice} gold each");
        break;
    case 3:
        if (name == "Nate") { Console.WriteLine($"Climbing Equipment is {climbingEquipmentPrice / 2} gold with your discount!"); }
        else
            Console.WriteLine($"Climbing equipment is {climbingEquipmentPrice} gold each");
        break;
    case 4:
        if (name == "Nate") { Console.WriteLine($"Clean water is {cleanWaterPrice / 2} gold with your discount!"); }
        else
            Console.WriteLine($"Clean water is {cleanWaterPrice} gold.");
        break;
    case 5:
        if (name == "Nate") { Console.WriteLine($"A machete is {machetePrice / 2} gold with your discount!"); }
        else
            Console.WriteLine($"A machete is {machetePrice} gold.");
        break;
    case 6:
        if (name == "Nate") { Console.WriteLine($"A canoe is {canoePrice / 2} gold with your discount!"); }
        else
            Console.WriteLine($"A canoe is {canoePrice} gold.");
        break;
    case 7:
        if (name == "Nate") { Console.WriteLine($"Food supplies are {foodSuppliesPrice / 2} gold with your discount!"); }
        else
            Console.WriteLine($"Food supplies will be {foodSuppliesPrice} gold each.");
        break;
    default:
        Console.WriteLine("Sorry, that's an invalid entry.");
        break;
}


