using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        public Classroom(int capacity)
        {
            this.Capacity = capacity;
            this.Students = new List<Student>();
        }

        public int Capacity { get; set; }
        public List<Student> Students { get; set; }
        public int Count
        {
            get
            {
                return Students.Count;
            }
        }

        public string RegisterStudent(Student student)
        {
            if (Capacity > Students.Count)
            {
                Students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return "No seats in the classroom";
            }
        }

        public string DismissStudent(string firstName, string lastName)
        {
            foreach (var student in Students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    Students.Remove(student);
                    return $"Dismissed student {firstName} {lastName}";
                }
            }
            return "Student not found";
        }

        public string GetSubjectInfo(string subject)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Subject: {subject}");
            sb.AppendLine("Students:");
            bool hasStudents = false;
            foreach (var student in Students)
            {
                if (student.Subject == subject)
                {
                    sb.AppendLine($"{student.FirstName} {student.LastName}");
                    hasStudents = true;
                }
            }
            if (!hasStudents)
            {
                sb.Clear();
                sb.AppendLine("No students enrolled for the subject");
            }
            return sb.ToString().TrimEnd();
        }
        public int GetStudentsCount()
        {
            return this.Count;
        }

        public Student GetStudent(string firstName, string lastName)
        {
            foreach (var student in Students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return student;
                }
            }
            return null;
        }
    }
}
