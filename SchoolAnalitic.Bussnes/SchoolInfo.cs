using System;

namespace SchoolAnalitic.Bussnes
{
    public class SchoolInfo
    {   
        public string Code { get; }
        public string Name { get; }
        public string Adress { get; }
        public int YearBuilded { get; }        
        //public StudentInfo Student { get; }

        public SchoolInfo (string code, string name, string adress, int yearBuilded)
        {
            Code = code;
            Name = name;
            Adress = adress;
            YearBuilded = yearBuilded;
            //Student = student;
        }
     
    }
}
