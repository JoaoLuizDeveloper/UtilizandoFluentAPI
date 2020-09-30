using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiveEFCore.Entities
{
    public class Student
    {
        public Student()
        {

        }

        public Student(string name)
        {
            Name = name;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }

        //Fazendo 1:1 em school
        public School School { get; set; }
        public int SchoolId { get; set; }
    }
}
