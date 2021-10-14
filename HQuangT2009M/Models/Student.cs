using System;

namespace HQuangT2009M.Model
{
    public class Student
    {
        public string RollNumber { get; set; } //auto properties _rollNumber (private) + getter + setter.
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        
        public StudentStatus Status { get; set; }

        public bool IsNewStudent()
        {
            return DateTime.Now.CompareTo(CreatedAt.AddMonths(2)) <= 0;
        }
        public bool IsDeactive()
        {
            return Status == StudentStatus.Deactive;
        }
        
        public override string ToString()
        {
            return $"{RollNumber,-30}{"|",10}{FullName,-30}{"|",10}{IsNewStudent(),-30}{"|",10}{Status,-30}";
        }
    }
}