using System;
using System.Collections.Generic;
namespace Final_Project
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private string email;
        private List<Student> allStudents = new List<Student>();
        public Student(string first, string last, string mail)
        {

            firstName = first;
            lastName = last;
            email = mail;
        }

        public Student() : this("Anonymous", "Anonymous", "guest@example.com")
        {

        }
        public override string ToString() {
            return String.Format($"{firstName} {lastName} | {email}");
            }

        public void AddStudent()
        {
            Console.WriteLine("First name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Email address: ");
            string email = Console.ReadLine();
            Student addStudent = new Student(firstName, lastName, email);
            allStudents.Add(addStudent);
        }
        public void DeleteStudent()
        {
            if (allStudents.Count == 0)
            {
                Console.WriteLine("There is no students in the list.");
            }
            for (int i = 0; i < allStudents.Count; i++)
            {
                ListStudents();
                    Console.WriteLine("Enter # to delete");
                int num = Convert.ToInt32(Console.ReadLine());
                allStudents.RemoveAt(num - 1);
                break;
            }
            
        }
        public void EditStudent()
        {
            Console.WriteLine("Enter # to edit ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter new first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter new last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter new email: ");
            string email = Console.ReadLine();
            allStudents.RemoveAt(num - 1);
            Student addStudent = new Student(firstName, lastName, email);
            allStudents.Insert(num - 1,addStudent);
        }
        public void ListStudents()
        {
            if (allStudents.Count == 0)
            {
                Console.WriteLine("There is no students in the list.");
                AddStudent();
            }
            for (int i=0; i < allStudents.Count; i++)
            {
                Student aStudent = allStudents[i];
                Console.WriteLine($"{i+1}. {aStudent.firstName.ToString()} {aStudent.lastName.ToString()} | {aStudent.email.ToString()}");
                
                
            }
            
        }

    }
}
