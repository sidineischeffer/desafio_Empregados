using System;
using System.Globalization;

namespace DepartmentPayroll
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.Write("Nome do departamento: ");
            string deptName = Console.ReadLine();
            Console.Write("Dia do pagamento: ");
            int payDay = int.Parse(Console.ReadLine());
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Telefone: ");
            string phone = Console.ReadLine();

            Address address = new Address(email, phone);
            Department dept = new Department(deptName, payDay, address);

           
            Console.Write("Quantos funcionários tem o departamento? ");
            int numEmployees = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numEmployees; i++)
            {
                Console.WriteLine($"Dados do funcionário {i}:");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salário: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                dept.addEmployee(new Employee(name, salary));
            }

            dept.showReport();
            Console.Write("");
        }
    }
}
