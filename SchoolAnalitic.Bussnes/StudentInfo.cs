using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAnalitic.Bussnes
{
    public class StudentInfo
    {   
        public int Id { get; }

        public string SchoolCode { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public int YearOfBirth { get; }

        public StudentInfo (int id, string schoolCode, string firstName, string lastName, int yearOfBirth)
        {
            Id = id;
            SchoolCode = schoolCode;
            FirstName = firstName;
            LastName = lastName;
            YearOfBirth = yearOfBirth;
        }
    }
}
