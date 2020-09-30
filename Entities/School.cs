using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiveEFCore.Entities
{
    public class School
    {
        public School() { }
        public School(int id, string name) 
        {
            Id = id;
            Name = name;
            Active = true;
        }

        public School(string name)
        {
            Name = name;
        }

        //public Guid Id { get; private set; }
        public int Id { get; private set; }
        public string Name { get; private set; }
        public bool Active { get; private set; }

        //1:1  em Contact information
        public ContactInformation ContactInformation { get; set; }
        //Fazendo 1:N em studant
        public List<Student> Student { get; set; }
        //public int StudentId { get; set; }

        public void AddStudent(string name)
        {
            Student.Add(new Student(name));
        }

        public void AddContactInformation(string fullAddress)
        {
            ContactInformation = new ContactInformation(fullAddress, "12345" );
        }
    }
}
