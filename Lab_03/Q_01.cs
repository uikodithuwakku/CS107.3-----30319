using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    /*public class Course
    {
        private string CourseName;
        private string InstructorName;
        private double grade;

        public Course(string CourseName) //constructor
        {
            if (string.IsNullOrEmpty(CourseName)) //using this check whether CourseName empty or not
            {
                throw new ArgumentException("Course name can't be empty");
            }
            this.CourseName = CourseName;
        }

        public string courseName => CourseName; // read only property

        public double Grade
        {
            get => grade;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    grade = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Grade must be between 0 & 100");
                }
            }
        }

        public void SetInstructureName(string InstructorName)
        {
            if (string.IsNullOrEmpty(InstructorName))
            {
                throw new ArgumentException("Instructor name cannot be empty");
            }
            this.InstructorName = InstructorName;
        }

        private string CalculateGrade()
        {
            if (grade >= 75)
            {
                return "A";
            }
            else if (grade >= 65)
            {
                return "B";
            }
            else if (grade >= 55)
            {
                return "C";
            }
            else if (grade >= 35)
            {
                return "S";
            }
            else
            {
                return "F";
            }
        }

        public void PrintCourseInfo()
        {
            Console.WriteLine($"Course Name :{CourseName}");
            Console.WriteLine($"Instructor Name : {InstructorName}");
            Console.WriteLine($"Grade : {grade}");

        }
    }



        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Course Name :");
                string CourseName = Console.ReadLine();

                Console.WriteLine("Instructor Name :");
                string InstructorName = Console.ReadLine();

                Console.WriteLine("Marks :");
                double grade = Convert.ToDouble(Console.ReadLine());

                Course course = new Course(CourseName);

                course.PrintCourseInfo();
                Console.ReadLine();
            }
        }*/
}

