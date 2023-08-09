using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConAppStoreUpdateInTextFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\Mphasis\Live Session\SimpliLearn Projects\Phase 1 Final Project\Storing and Updating Teacher Records\ConAppStoreUpdateInTextFile\TeacherRecord.txt";
            TeacherManager teacherManager = new TeacherManager(filePath);
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Select an option");
                Console.WriteLine("1. Add Teacher");
                Console.WriteLine("2. Update Teacher");
                Console.WriteLine("3. Display Teachers");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Teacher ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Teacher Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Class and Section: ");
                        string classSection = Console.ReadLine();

                        teacherManager.AddTeacher(new Teacher(id, name, classSection));
                        Console.WriteLine("Teacher Added");
                        break;
                    case 2:
                        Console.Write("Enter the Teacher ID to be updated: ");
                        int updateId = int.Parse(Console.ReadLine());
                        Console.Write("Enter New Name: ");
                        string newName = Console.ReadLine();
                        Console.Write("Enter New Class and Section: ");
                        string newClassSection = Console.ReadLine();

                        teacherManager.UpdateTeacher(updateId, new Teacher(updateId, newName, newClassSection));
                        Console.WriteLine("Teacher updated.");
                        break;
                    case 3:
                        teacherManager.DisplayTeachers();
                        break;
                    case 4:
                        isRunning = false;
                        Console.WriteLine("Exiting the program.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }
    }
}
