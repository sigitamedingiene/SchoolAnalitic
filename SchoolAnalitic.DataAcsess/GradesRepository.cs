using SchoolAnalitic.Bussnes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAnalitic.DataAcsess
{
    public class GradesRepository
    {
        private List<Grades> gradesList1 { get; }

        public GradesRepository()
        {   
            gradesList1 = new List<Grades>();
            var addedAt = DateTime.Now;
            gradesList1.Add(new Grades(1, 10, addedAt));
            gradesList1.Add(new Grades(2, 8, addedAt));
            gradesList1.Add(new Grades(3, 10, addedAt));
            gradesList1.Add(new Grades(4, 7, addedAt));
            gradesList1.Add(new Grades(5, 10, addedAt));
            gradesList1.Add(new Grades(6, 9, addedAt));
            gradesList1.Add(new Grades(7, 8, addedAt));
            gradesList1.Add(new Grades(8, 5, addedAt));
            gradesList1.Add(new Grades(9, 7, addedAt));
            gradesList1.Add(new Grades(10, 6, addedAt));

        }
    }
}
