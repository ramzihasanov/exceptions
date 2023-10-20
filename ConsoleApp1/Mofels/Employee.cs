using ConsoleApp1.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Mofels
{
    public class Employee
    {
        private string _fullName;
        private int _experience;
        private string _departmentNo;
        private int _age;
        private int _salary;
        public int Id { get; } = 0;
        
        public Employee(int salary)
        {
            Id++;
            _salary = salary;

            
        }
        public string FullName
        {
            get => _fullName;
            set
            {
                string[] a=value.Trim().Split(' ');
                if (a.Length == 2) _fullName = value;
                else throw new InvalidFullNameException("fullname is not corrected");
            }
        }


        public string DepartmentNo
        { get => _departmentNo;
            set
            {
              string a=  value.ToString().Trim().Substring(0, 2).ToUpper();
                if (value.ToString().Substring(0, 2) == a) _departmentNo = value;
                else throw new InvalidDepartmentN0Exception("departmentno is not corrected");
            }
        }


        public int Age 
        { get => _age;
            set
            {
                if(value > 0&& value<150) _age = value;
                else throw new InvalidAgeException("age is not corrected");
            }
        }

        public int Experience 
        { get => _experience;
            set
            {
                if(value > 0 && _age-value>18) _experience = value;
                else throw new InvalidExperienceException("exception is not corrected");
            }
        }



    }
}


