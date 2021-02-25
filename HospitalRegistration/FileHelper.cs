using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRegistration
{
    class FileHelper
    {
        public void WriteToFile(string name, string surname, int age, List<Time> times, Department dep, int id,int time_id)
        {
            using (FileStream fs = new FileStream("Registration.txt", FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.ASCII))
                {
                    sw.WriteLine($"Name: {name}");
                    sw.WriteLine($"Surname: {surname}");
                    sw.WriteLine($"Age: {age}");
                    for (int i = 0; i < dep.Doctors.Count; i++)
                    {
                        if (dep.Doctors[i].ID == id)
                        {
                            sw.WriteLine(dep.Doctors[i]);
                        }
                    }
                    for (int i = 0; i < times.Count; i++)
                    {
                        if (times[i].ID == time_id)
                        {
                            sw.WriteLine(times[i]);
                        }
                    }
                    sw.WriteLine();
                }
            }
        }

        public void ReadFromFile(string fileName)
        {
            using (FileStream fs = new FileStream("Registration.txt", FileMode.OpenOrCreate))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.ASCII))
                {
                    var text = sr.ReadToEnd();
                    Console.WriteLine(text);
                }
            }
        }
    }
}
