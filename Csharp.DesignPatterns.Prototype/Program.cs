//Without cloning
Employee emp1 = new Employee();
emp1.Name = "Anurag";
emp1.Department = "IT";
Employee emp2 = emp1;
emp2.Name = "Pranaya";
Console.WriteLine("Emplpyee 1: ");
Console.WriteLine("Name: " + emp1.Name + ", Department: " + emp1.Department);
Console.WriteLine("Emplpyee 2: ");
Console.WriteLine("Name: " + emp2.Name + ", Department: " + emp2.Department);

//With cloning
Employee emp3 = new Employee();
emp3.Name = "Anurag";
emp3.Department = "IT";
Employee emp4 = emp1;
emp4.Name = "Pranaya";
Console.WriteLine("Emplpyee 1: ");
Console.WriteLine("Name: " + emp3.Name + ", Department: " + emp3.Department);
Console.WriteLine("Emplpyee 2: ");
Console.WriteLine("Name: " + emp4.Name + ", Department: " + emp4.Department);

public class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
}

public class EmployeeWithClone
{
    public string Name { get; set; }
    public string Department { get; set; }
    public Employee GetClone()
    {
        return (Employee)this.MemberwiseClone();
    }
}