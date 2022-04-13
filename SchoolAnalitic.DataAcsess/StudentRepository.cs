using SchoolAnalitic.Bussnes;
using System;
using System.Collections.Generic;

namespace SchoolAnalitic.DataAcsess
{
    public class StudentRepository
    {
        private List<StudentInfo> studentList { get; }

        public StudentRepository()
        {//tarkime imame sarasa is mokiniu registro.
            studentList = new List<StudentInfo>();
            studentList.Add(new StudentInfo(1, "SP", "Antanas", "Antanavicius", 2005));
            studentList.Add(new StudentInfo(2, "VP", "Vilius", "Viliuska", 2000));
            studentList.Add(new StudentInfo(3, "SP", "Sofia", "Lalala", 2000));
            studentList.Add(new StudentInfo(4, "VG", "Antanas", "Tatata", 2001));
            studentList.Add(new StudentInfo(5, "VP", "Leila", "Nanana", 2004));
            studentList.Add(new StudentInfo(6, "VP", "Tomas", "Antanavicius", 2003));
            studentList.Add(new StudentInfo(7, "SP", "Vilius", "Narta", 2001));
            studentList.Add(new StudentInfo(8, "VG", "Klara", "Jajaja", 2002));
            studentList.Add(new StudentInfo(9, "VP", "Kajus", "Kajauskas", 2000));
            studentList.Add(new StudentInfo(10, "VG", "Nora", "Norara", 2005));
        }

        public List<StudentInfo> Retrieve()
        {
            return studentList;
        }
    }
}
