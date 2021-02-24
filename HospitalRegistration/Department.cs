using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRegistration
{
    abstract class Department
    {
        public string Name { get; set; }
        public List<Doctor> Doctors { get; set; }
        public override string ToString()
        {
            return $"Name of department: {Name}";
        }
    }
}
