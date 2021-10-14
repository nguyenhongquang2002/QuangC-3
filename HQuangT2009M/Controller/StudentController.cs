using System;
using System.Collections.Generic;
using HQuangT2009M.Model;

namespace HQuangT2009M.Controller
{
    public class StudentController
    {
        public void PrintListStudent(List<Student> students)
        {
            Console.WriteLine("Student List");
            Console.WriteLine("========================================================================================");
            Console.WriteLine("RollNumber\t\t|Name\t\tIs New\t\tStatus");
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }

        public Student CreateStudent()
        {
            Console.WriteLine("Please enter rollnumber:");
            var rollNumber = Console.ReadLine();
            Console.WriteLine("Please enter fullname:");
            var fullName = Console.ReadLine();
            Console.WriteLine("Please enter email:");
            var email = Console.ReadLine();
            Console.WriteLine("Please enter phone:");
            var phone  = Console.ReadLine();
            Console.WriteLine("Please enter birthday(yyyy-mm-dd:,for example 2010-01-30");
            var birthday = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Please enter status (1 is active , - 1 is deleted,0 is deactive)");
            var status = (StudentStatus) Int32.Parse( Console.ReadLine());
            var student = new Student
            {
                RollNumber = rollNumber,
                FullName = fullName,
                Birthday = birthday,
                CreatedAt = DateTime.Now,
                Email = email,
                Phone = phone,
                Status = status
            };
            return student;
        }
    }
}