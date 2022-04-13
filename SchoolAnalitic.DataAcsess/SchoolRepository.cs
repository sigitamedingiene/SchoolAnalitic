using SchoolAnalitic.Bussnes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAnalitic.DataAcsess
{
    public class SchoolRepository
    {
        private List<SchoolInfo> schoolInfo { get; }

        public SchoolRepository()
        {
            schoolInfo = new List<SchoolInfo>();
            schoolInfo.Add(new SchoolInfo("SP", "Sauletekio progimnazija", "Lauku g. 3", 1865));
            schoolInfo.Add(new SchoolInfo("VG", "Varpo gimnazija", "Nemuno g. 3", 1950));
            schoolInfo.Add(new SchoolInfo("VP", "Versmes progimnazija", "Pievu g. 3", 1899));
        }

        public bool MustAddStudent(string code)
        {
            for (int i = 0; i < schoolInfo.Count; i++)
            {
                if (code == schoolInfo[i].Code)
                {
                    return true;
                }
            }
           return false;
        }

        public List<SchoolInfo> Retrieve()
        {
            return schoolInfo;
        }
    }
}
