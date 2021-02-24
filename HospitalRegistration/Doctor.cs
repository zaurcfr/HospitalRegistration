using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRegistration
{
    class Doctor
    {
        public int ID { get; set; }
        public static int Doctor_ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Experience { get; set; }
        public bool[] Reserve { get; set; } = { false, false, false };

        public void Meeting(int id)
        {
            if (id > 0 && id < 4)
            {
                if (Reserve[id - 1] == false)
                {
                    Reserve[id - 1] = true;
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Already Reserved!");
                }
            }
            else Console.WriteLine("Wrong ID!");
        }

        public Doctor()
        {
            ID = ++Doctor_ID;

        }

        public override string ToString()
        {
            return $"ID: {ID}\nName: {Name}\nSurname: {Surname}\nExperience: {Experience} year(s)\n";
        }
    }
}
