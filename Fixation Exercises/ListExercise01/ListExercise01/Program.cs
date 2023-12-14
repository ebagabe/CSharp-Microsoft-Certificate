using System.Globalization;
using ListExercise01;

Console.Write("How many employees will be registered? ");
int employeeNumbers = int.Parse(Console.ReadLine());

List<Employer> employeeList = new List<Employer>();

for (int i = 1; i <= employeeNumbers; i++)
{
    Console.WriteLine($"Employee #{i}:");
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    
    Console.Write("Name: ");
    string name = Console.ReadLine();
    
    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    
    employeeList.Add(new Employer(id, name, salary));
    Console.WriteLine();
}

Console.Write("Enter the employee id that will have salary increase: ");
int searchId = int.Parse(Console.ReadLine());

Employer emp = employeeList.Find(x => x.Id == searchId);

if (emp != null) 
{
    Console.Write("Enter the percentage: ");
    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    emp.IncreaseSalary(percentage);
}
else
{
    Console.WriteLine("This id does not exist!");
}

Console.WriteLine();
Console.WriteLine("Updated list of employees:");

foreach (Employer obj in employeeList)
{
    Console.WriteLine(obj);
}