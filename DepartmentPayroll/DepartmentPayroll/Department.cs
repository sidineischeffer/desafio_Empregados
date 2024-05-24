using System.Collections.Generic;
using System;

public class Department
{
    public string name { get; set; }
    public int payDay { get; set; }
    private Address address { get; set; }
    public List<Employee> employees { get; set; } = new List<Employee>();

   
    public Department() { }

    public Department(string name, int payDay, Address address)
    {
        this.name = name;
        this.payDay = payDay;
        this.address = address;
    }

    public void addEmployee(Employee emp)
    {
        employees.Add(emp);
    }

    public void removeEmployee(Employee emp)
    {
        employees.Remove(emp);
    }

    public double payroll()
    {
        double sum = 0.0;
        foreach (Employee emp in employees)
        {
            sum += emp.salary;
        }
        return sum;
    }

   
    public void showReport()
    {
        Console.WriteLine();
        Console.WriteLine("FOLHA DE PAGAMENTO:");
        Console.WriteLine($"Departamento {name} = R$ {payroll().ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Pagamento realizado no dia {payDay}");
        Console.WriteLine("Funcionários:");
        foreach (Employee emp in employees)
        {
            Console.WriteLine(emp.name);
        }
        Console.WriteLine($"Para dúvidas favor entrar em contato: {address.email}");
    }
}