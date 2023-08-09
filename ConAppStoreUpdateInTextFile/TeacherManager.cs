using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConAppStoreUpdateInTextFile
{
    public class TeacherManager
    {
        private string filePath;
        public TeacherManager(string path)
        {
            filePath = path;
        }
        public void AddTeacher(Teacher teacher)
        {
            using(StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine($"{teacher.ID}, {teacher.Name}, {teacher.ClassSection}");
            }
        }
        public void UpdateTeacher(int id, Teacher updatedTeacher)
        {
            string[] lines = File.ReadAllLines(filePath);
            using(StreamWriter writer = new StreamWriter(filePath))
            {
                foreach(string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (int.Parse(parts[0]) == id)
                    {
                        writer.WriteLine($"{updatedTeacher.ID}, {updatedTeacher.Name}, {updatedTeacher.ClassSection}");
                    }
                    else
                    {
                        writer.WriteLine(line);
                    }
                }
            }
        }
        public void DisplayTeachers()
        {
            Console.WriteLine("Teacher Records: ");
            string[] lines = File.ReadAllLines(filePath);
            foreach(string line in lines)
            {
                string[] parts = line.Split(',');
                Console.WriteLine($"ID: {parts[0]}, Name: {parts[1]}, Class Section: {parts[2]}");
            }
        }
    }
}
