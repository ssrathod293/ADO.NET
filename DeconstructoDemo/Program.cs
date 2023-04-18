using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeconstructoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher obj = new Teacher(1005, "Suresh", "English", "Lecturer", 25000.00);
            //Console.WriteLine($"Id:{obj.Id} Name:{obj.Name} Subject:{obj.Subject} Designation {obj.Subject} Salary:{obj.Salary}");
            //we can access above feild if only these are intialised with public or using property or indexer
            //or deconstructor
            (int Id, string Name, string Subject, string Designation, double Salary) = obj;
            Console.WriteLine("Teacher Id: " + Id);
            Console.WriteLine("Teacher Name: " + Name);
            Console.WriteLine("Teacher Subject: " + Subject);
            Console.WriteLine("Teacher Designation: " + Designation);
            Console.WriteLine("Teacher Salary: " + Salary);

            var (Id1, Name1, Salary1) = obj;
            Console.WriteLine("Teacher Id: " + Id1);
            Console.WriteLine("Teacher Name: " + Name1);
            Console.WriteLine("Teacher Salary: " + Salary1);
            Console.ReadLine();

        }
    }
    public class Teacher
    {
       int Id;
         string Name, Subject, Designation;

        double Salary;
        public Teacher(int Id, string Name, string Subject, string Designation, Double Salary)
        {
            this.Id = Id;
            this.Name = Name;
            this.Subject = Subject;
            this.Designation = Designation;
            this.Salary = Salary;
        }
        public void Deconstruct(out int Id, out string Name, out string Subject, out string Designation, out double Salary)
        {
            Id = this.Id;
            Name = this.Name;
            Subject = this.Subject;
            Designation = this.Designation;
            Salary = this.Salary;
        }
        public void Deconstruct(out int Id, out string Name, out double Salary)
        {
            Id = this.Id; Name = this.Name; Salary = this.Salary;
        }
    }
   
}
