// Just Sum

int firstNumber = 12;
int secondNumber = 7;

Console.WriteLine(firstNumber + secondNumber);

// Mix data types
Console.WriteLine("----------------------");
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

Console.WriteLine("----------------------");
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");

Console.WriteLine("----------------------");
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");