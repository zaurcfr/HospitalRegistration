using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HospitalRegistration
{
    class Program
    {
        static void MakeMeeting(Department dep, int choice, int id)
        {
            if (choice == 1)
            {
                dep.Doctors[id].Meeting(choice);
            }
            else if (choice == 2)
            {
                dep.Doctors[id].Meeting(choice);
            }
            else if (choice == 3)
            {
                dep.Doctors[id].Meeting(choice);
            }
            Thread.Sleep(1000);
        }
        static void PrintDoctors(Department dep)
        {
            foreach (var item in dep.Doctors)
            {
                Console.WriteLine(item);
            }
        }
        static void PrintTimes(Department dep, List<Time> times, int id)
        {
            Console.Clear();
            for (int i = 0; i < times.Count; i++)
            {
                if (dep.Doctors[id].Reserve[i] == false)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(times[i]);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(times[i]);
                    Console.ResetColor();
                }
            }
        }
        static void PrintMenu()
        {
            Console.WriteLine("1. Pediatric Department");
            Console.WriteLine("2. Traumatology Department");
            Console.WriteLine("3. Dentist Department");
            Console.WriteLine("0. Exit");

        }

        static void Main(string[] args)
        {
            PediatricDepartment pediatricDepartment = new PediatricDepartment
            {
                Name = "Pediatric Department",
                Doctors = new List<Doctor>
                {
                    new Doctor
                    {
                        Name = "Glen",
                        Surname = "Fry",
                        Experience = 1
                    },
                    new Doctor
                    {
                        Name = "James",
                        Surname = "Richardson",
                        Experience = 4
                    },
                    new Doctor
                    {
                        Name = "Cherise",
                        Surname = "Wilton",
                        Experience = 2
                    },
                }
            };
            TraumatologyDepartment traumatologyDepartment = new TraumatologyDepartment
            {
                Name = "Traumatology Department",
                Doctors = new List<Doctor>
                {
                    new Doctor
                    {
                        Name = "Mark",
                        Surname = "Warren",
                        Experience = 2
                    },
                    new Doctor
                    {
                        Name = "Darren",
                        Surname = "Myers",
                        Experience = 1
                    },
                    new Doctor
                    {
                        Name = "Ronnie",
                        Surname = "Martin",
                        Experience = 4
                    },
                    new Doctor
                    {
                        Name = "Marsha",
                        Surname = "Sergeant",
                        Experience = 6
                    }
                }
            };
            DentistDepartment dentistDepartment = new DentistDepartment
            {
                Name = "Dentist Department",
                Doctors = new List<Doctor>
                {
                    new Doctor
                    {
                        Name = "Todd",
                        Surname = "Day",
                        Experience = 4
                    },
                    new Doctor
                    {
                        Name = "Lamar",
                        Surname = "Edwards",
                        Experience = 7
                    }
                }
            };

            List<Time> times = new List<Time>
            {
                new Time
                {
                    StartTime=new DateTime(2020,02,24,09,00,00),
                    EndTime=new DateTime(2020,02,24,11,00,00),
                },
                new Time
                {
                    StartTime=new DateTime(2020,02,24,12,00,00),
                    EndTime=new DateTime(2020,02,24,14,00,00),
                },
                new Time
                {
                    StartTime=new DateTime(2020,02,24,15,00,00),
                    EndTime=new DateTime(2020,02,24,17,00,00),
                }
            };

            FileHelper fh = new FileHelper();

            bool b = true;
            while (b)
            {
                Console.Clear();
                Console.WriteLine("Enter your name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your surname: ");
                string surname = Console.ReadLine();
                Console.WriteLine("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your email: ");
                string email = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"Welcome {name} {surname}!");
                Thread.Sleep(1000);

                Console.WriteLine("Select department which you want to apply!");
                PrintMenu();
                string choice = Console.ReadLine();
                int choiceDoc;
                int choiceTime;

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Choose doctor you want to meet: ");
                        PrintDoctors(pediatricDepartment);
                        choiceDoc = Convert.ToInt32(Console.ReadLine());
                        switch (choiceDoc)
                        {
                            case 1:
                                Console.Clear();
                                PrintTimes(pediatricDepartment, times, 0);
                                Console.WriteLine("Choose time: ");
                                choiceTime = Convert.ToInt32(Console.ReadLine());
                                MakeMeeting(pediatricDepartment, choiceTime, 0);
                                fh.WriteToFile(name, surname, age, times, pediatricDepartment, 0, choiceTime);
                                break;
                            case 2:
                                Console.Clear();
                                PrintTimes(pediatricDepartment, times, 1);
                                Console.WriteLine("Choose time: ");
                                choiceTime = Convert.ToInt32(Console.ReadLine());
                                MakeMeeting(pediatricDepartment, choiceTime, 1);
                                fh.WriteToFile(name, surname, age, times, pediatricDepartment, 1, choiceTime);
                                break;
                            case 3:
                                Console.Clear();
                                PrintTimes(pediatricDepartment, times, 2);
                                Console.WriteLine("Choose time: ");
                                choiceTime = Convert.ToInt32(Console.ReadLine());
                                MakeMeeting(pediatricDepartment, choiceTime, 2);
                                fh.WriteToFile(name, surname, age, times, pediatricDepartment, 2, choiceTime);
                                break;
                            default:
                                Console.Clear();
                                break;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Choose doctor you want to meet: ");
                        PrintDoctors(traumatologyDepartment);
                        choiceDoc = Convert.ToInt32(Console.ReadLine());
                        switch (choiceDoc)
                        {
                            case 4:
                                Console.Clear();
                                PrintTimes(traumatologyDepartment, times, 0);
                                Console.WriteLine("Choose time: ");
                                choiceTime = Convert.ToInt32(Console.ReadLine());
                                MakeMeeting(traumatologyDepartment, choiceTime, 0);
                                fh.WriteToFile(name, surname, age, times, traumatologyDepartment, 0, choiceTime);
                                break;
                            case 5:
                                Console.Clear();
                                PrintTimes(traumatologyDepartment, times, 1);
                                Console.WriteLine("Choose time: ");
                                choiceTime = Convert.ToInt32(Console.ReadLine());
                                MakeMeeting(traumatologyDepartment, choiceTime, 1);
                                fh.WriteToFile(name, surname, age, times, traumatologyDepartment, 1, choiceTime);
                                break;
                            case 6:
                                Console.Clear();
                                PrintTimes(traumatologyDepartment, times, 2);
                                Console.WriteLine("Choose time: ");
                                choiceTime = Convert.ToInt32(Console.ReadLine());
                                MakeMeeting(traumatologyDepartment, choiceTime, 3);
                                fh.WriteToFile(name, surname, age, times, traumatologyDepartment, 2, choiceTime);
                                break;
                            case 7:
                                Console.Clear();
                                PrintTimes(traumatologyDepartment, times, 3);
                                Console.WriteLine("Choose time: ");
                                choiceTime = Convert.ToInt32(Console.ReadLine());
                                MakeMeeting(traumatologyDepartment, choiceTime, 4);
                                fh.WriteToFile(name, surname, age, times, traumatologyDepartment, 3, choiceTime);
                                break;
                            default:
                                Console.Clear();
                                break;
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Choose doctor you want to meet: ");
                        PrintDoctors(dentistDepartment);
                        choiceDoc = Convert.ToInt32(Console.ReadLine());
                        switch (choiceDoc)
                        {
                            case 8:
                                Console.Clear();
                                PrintTimes(dentistDepartment, times, 0);
                                Console.WriteLine("Choose time: ");
                                choiceTime = Convert.ToInt32(Console.ReadLine());
                                MakeMeeting(dentistDepartment, choiceTime, 0);
                                fh.WriteToFile(name, surname, age, times, dentistDepartment, 0, choiceTime);
                                break;
                            case 9:
                                Console.Clear();
                                PrintTimes(dentistDepartment, times, 1);
                                Console.WriteLine("Choose time: ");
                                choiceTime = Convert.ToInt32(Console.ReadLine());
                                MakeMeeting(dentistDepartment, choiceTime, 1);
                                fh.WriteToFile(name, surname, age, times, dentistDepartment, 1, choiceTime);
                                break;
                            default:
                                Console.Clear();
                                break;
                        }
                        break;
                    case "0":
                        b = false;
                        break;
                    default:
                        break;
                }




            }
        }
    }
}
