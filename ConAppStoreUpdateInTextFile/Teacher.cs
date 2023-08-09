using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppStoreUpdateInTextFile
{
    public class Teacher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ClassSection { get; set; }
        public Teacher(int id, string name, string classSection)
        {
            ID = id;
            Name = name;
            ClassSection = classSection;
        }
    }
}
