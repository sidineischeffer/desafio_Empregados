public class Employee
{
    public string name { get; set; }
    public double salary { get; set; }

    public Employee(string names, double salarys)
    {
        this.name = names;
        this.salary = salarys;
    }
}