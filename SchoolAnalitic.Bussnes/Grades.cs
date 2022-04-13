using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAnalitic.Bussnes
{
    public class Grades
    {
        public int Id { get; }
        public int Grade { get; }
        public DateTime AddedAt { get; }

        public Grades (int id, int grade, DateTime addedAt)
        {
            Id = id;
            Grade = grade;
            AddedAt = addedAt;
        }
    }
}
