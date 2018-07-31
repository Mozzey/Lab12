using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab12.Library;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> students = new List<Person>
            {
                new Student("Michael", "123 Main", 10000.00),
                new Student("Mike", "234 Main", 10000.00),
                new Student("Catherine", "345 Main", 10000.00),
                new Student("Jacob", "456 Main", 10000.00),
                new Student("Sean", "567 Main", 10000.00),
                new Student("Shawn", "678 Main", 10000.00),
                new Student("Brad", "789 Main", 10000.00),
                new Student("Bruce", "987 Main", 10000.00),
                new Student("Rabin", "876 Main", 10000.00),
                new Student("Chris", "765 Main", 10000.00),
                new Student("Aquionette", "654 Main", 10000.00),
                new Student("Ross", "543 Main", 10000.00)
            };
            List<Person> staffMembers = new List<Person>
            {
                new Staff("Kelsey", "Start Garden", 9001),
                new Staff("John", "Start Garden", 9001),
                new Staff("Brian", "Start Garden", 9001),
                new Staff("Justin", "Start Garden", 9001)
            };
            Console.WriteLine("=========================================================");
            Console.WriteLine("\t\tStudents");
            Console.WriteLine("=========================================================");
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("\t\tStaff");
            Console.WriteLine("=========================================================");
            foreach (var staff in staffMembers)
            {
                Console.WriteLine(staff.ToString());
            }

            Console.ReadLine();
        }
    }
}
