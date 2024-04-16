using System;

public interface ISalary
{
    decimal CalculateSalary();
}

public class JuniorSalary : ISalary
{
    public decimal CalculateSalary()
    {
        return 30000;  
    }
}

public class SeniorSalary : ISalary
{
    public decimal CalculateSalary()
    {
        return 80000;  
    }
}

public abstract class Employee
{
    public abstract ISalary GetSalary();
}

public class JuniorEmployee : Employee
{
    public override ISalary GetSalary()
    {
        return new JuniorSalary();
    }
}

public class SeniorEmployee : Employee
{
    public override ISalary GetSalary()
    {
        return new SeniorSalary();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create instances of JuniorEmployee and SeniorEmployee
        Employee juniorEmployee = new JuniorEmployee();
        Employee seniorEmployee = new SeniorEmployee();

        // Get salaries for Junior and Senior Employees
        ISalary juniorSalary = juniorEmployee.GetSalary();
        ISalary seniorSalary = seniorEmployee.GetSalary();

        // Print salaries
        Console.WriteLine($"The salary for a Junior Employee is: {juniorSalary.CalculateSalary():C}");
        Console.WriteLine($"The salary for a Senior Employee is: {seniorSalary.CalculateSalary():C}");
    }
}