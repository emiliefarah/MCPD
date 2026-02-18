using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice6.Interfaces;
using Exercice6.Models;

namespace Exercice6.Service
{
    public class StudentService:IStudentService
    {
       private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository repo)
            {
            _studentRepository = repo;
        }

        public Student AddStudent(Student student)
        {
            return _studentRepository.AddStudent(student);
        }
        public List <Student>Students()
        {
            return _studentRepository.GetAll();
        }


    }
}
