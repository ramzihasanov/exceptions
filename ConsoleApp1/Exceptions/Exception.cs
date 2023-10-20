using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exceptions
{
    public class InvalidFullNameException : Exception
    {
        public InvalidFullNameException()
        {

        }

        public InvalidFullNameException(string message) : base(message)
        {

        }
    }


    public class InvalidAgeException : Exception
    {
        public InvalidAgeException()
        {

        }

        public InvalidAgeException(string message) : base(message)
        {

        }
    }




    public class InvalidDepartmentN0Exception : Exception
    {

        public InvalidDepartmentN0Exception()
        {

        }

        public InvalidDepartmentN0Exception(string message):base(message)
        {

        }
    }








    public class InvalidExperienceException : Exception
    {
        public InvalidExperienceException()
        {

        }

        public InvalidExperienceException(string message):base(message)
        {

        }


    }


}
