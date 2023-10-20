
using ConsoleApp1.Exceptions;
using ConsoleApp1.Mofels;
using System.Reflection;

public class Program
{
    public static void Main()
    {
        Employee employee = new Employee(2000);
        try
        {
            Console.WriteLine("fullname daxil edin");
            employee.FullName = Console.ReadLine();
            Console.WriteLine("deapartmentNo daxil edin");
            employee.DepartmentNo = int.Parse(Console.ReadLine());
            Console.WriteLine("age daxil edin");
            employee.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("experience daxil edin");
            employee.Experience = int.Parse(Console.ReadLine());


        }
     
 
       
        catch (InvalidFullNameException ex)
        {
            Console.WriteLine(ex.Message);

        }
        catch (InvalidDepartmentN0Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InvalidAgeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InvalidExperienceException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }


    public static int CalculateSalary(Employee[] employees)
    {
        int totalSalary = 0;

        foreach (Employee employee in employees)
        {
            Type type = employee.GetType();
            FieldInfo fieldInfo = type.GetField("_salary", BindingFlags.NonPublic | BindingFlags.Instance);

            if (fieldInfo != null)
            {
                int salary = (int)fieldInfo.GetValue(employee);
                totalSalary += salary;
            }
        }

        return totalSalary;
    }

}