using System;

namespace Final_Project
{
    class Program
    {
        private const int ADD = 1;
        private const int DELETE = 2;
        private const int EDIT = 3;
        private const int LIST = 4;
        private const int EXIT = 5;

        static int GetMenuChoice()
        {
            Console.WriteLine("Student Club Management");
            Console.WriteLine("1. Add a student");
            Console.WriteLine("2. Delete a student");
            Console.WriteLine("3. Edit a student");
            Console.WriteLine("4. List the students");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Select option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            return option;
        }
        static void Main(string[] args)
        {
            
            Student Student = new Student();
            int choice = GetMenuChoice();
            while (choice != EXIT) 
            {
                switch (choice) {
                    case ADD:
                        Student.AddStudent();
                        break;
                    case DELETE:
                        Student.DeleteStudent();
                        break;
                    case EDIT:
                        Student.EditStudent();
                        break;
                    case LIST:
                        Student.ListStudents();
                        break;

                }
                choice = GetMenuChoice();
            }
        }
    }
}
