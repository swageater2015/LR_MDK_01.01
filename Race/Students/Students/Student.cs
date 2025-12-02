using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string GroupNumber { get; set; }

        public override string ToString()
        {
            return $"{LastName} {FirstName} {MiddleName} {GroupNumber}";
        }

        public string ToCsvString()
        {
            return $"{LastName},{FirstName},{MiddleName},{GroupNumber}";
        }
    }
}
