using System.Globalization;

namespace ListExercise01;

public class Employer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; private set; }

    public Employer(int id, string name, double salary)
    {
        Id = id;
        Name = name;
        Salary = salary;
    }

    public void IncreaseSalary(double percentage)
    {
        Salary += Salary * percentage / 100.0;
    }

    public override string ToString()
    {
        return $"{Id}, {Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}\n";
    }
    
}