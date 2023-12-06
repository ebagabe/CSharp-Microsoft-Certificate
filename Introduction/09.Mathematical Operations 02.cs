int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;
decimal decimalQuotient = 7.0m / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);
Console.WriteLine($"Decimal quotient: {decimalQuotient}");

// Perform division using literal decimal data
Console.WriteLine("---------------");
int first = 7;
int second = 5;
decimal newQuotient = (decimal)first / (decimal)second;
Console.WriteLine(newQuotient);

// Determine the remainder after dividing integers
Console.WriteLine("---------------");
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

// Order of operations
Console.WriteLine("---------------");
int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);
