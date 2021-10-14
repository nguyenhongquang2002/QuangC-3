using System;
using System.Collections.Generic;
using HQuangT2009M.Controller;
using HQuangT2009M.Model;

namespace HQuangT2009M
{
    public enum StudentStatus // int, double, string
    {
        Vip = 2 ,
        Active = 1,
        Deactive =0,
        Deleted = -1
            
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            var list = new List<Student>();
            var studentController = new StudentController();
            list.Add(studentController.CreateStudent());
            studentController.PrintListStudent(list);
            /*var list = new List<Student>
            {
                new Student
                {
                    RollNumber = "H001",
                    FullName = "Hong Quang 1",
                    Email = "Quang1@gmail.com",
                    Birthday = DateTime.Parse("2002-05-30"),
                    CreatedAt = DateTime.Parse("2021-04-21"),
                    Phone = "0966186860",
                    Status = StudentStatus.Deactive
                },
                new Student
                {
                    RollNumber = "H002",
                    FullName = "Hong Quang 1",
                    Email = "Quang1@gmail.com",
                    Birthday = DateTime.Parse("2002-03-05"),
                    CreatedAt = DateTime.Parse("2021-04-04"),
                    Phone = "0966186860",
                    Status = StudentStatus.Deactive
                },
                new Student
                {
                    RollNumber = "H003",
                    FullName = "Hong Quang 1",
                    Email = "Quang1@gmail.com",
                    Birthday = DateTime.Parse("2002-05-05"),
                    CreatedAt = DateTime.Parse("2021-03-04"),
                    Phone = "0966186860",
                    Status = StudentStatus.Deactive
                },
                new Student
                {
                    RollNumber = "H001",
                    FullName = "Hong Quang 1",
                    Email = "Quang1@gmail.com",
                    Birthday = DateTime.Parse("2002-05-05"),
                    CreatedAt = DateTime.Parse("2021-06-04"),
                    Phone = "0966186860",
                    Status = StudentStatus.Deactive
                }
            };
            studentController.PrintListStudent(list);*/
        }
    }
}