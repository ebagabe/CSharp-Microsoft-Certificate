/*int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
*/

// CHALLENGE 
/*Random numericRandom = new Random();

int luckyNumber = numericRandom.Next(0,2);

Console.WriteLine($"{(luckyNumber == 1 ? "heads" : "tails")}");
*/

// CHALLENGE

string permission = "Manager";
int level = 55;

// Admin + Level > 55 = Welcome, Super Admin user
// Admin + Level < 55 = Welcome, Admin User
// Manager + Level >= 20 = Contact an Admin for access.
// Manager + Level <= 20 = You do not have sufficient privileges.
// You do not have sufficient privileges.

if (permission.Contains("Admin") && level >= 55)
{
    Console.WriteLine("Welcome, Super Admin user");
} 
else if (permission.Contains("Admin") && level < 55)
{
    Console.WriteLine("Welcome, Admin User");
} 
else if (permission.Contains("Manager") && level >= 20)
{
    Console.WriteLine("Contact an Admin for access");
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}

