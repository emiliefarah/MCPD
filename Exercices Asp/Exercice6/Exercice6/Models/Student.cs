using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }


        public Student() { }

        public Student(string firstname, string lastname,int age,string email)
        {
            FirstName=firstname;
            LastName=lastname;
            Age=age;
            Email=email;

        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} {Age} ans {Email}";
        }
    }
}
