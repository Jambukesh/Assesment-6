using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList studentGrades = new ArrayList();

            // Initialize studentGrades with the following integer values (in this order): 85, 92, 78, 95, 88.
            studentGrades.Add(85);
            studentGrades.Add(92);
            studentGrades.Add(78);
            studentGrades.Add(95);
            studentGrades.Add(88);
            foreach (int grade in studentGrades)
            {
                Console.WriteLine(grade);
            }

            // Calculate and display the sum of all the grades in 'studentGrades.
            int sum = 0;
            foreach (int grade in studentGrades)
            {
                sum += grade;
            }
            Console.WriteLine("Sum: " + sum);

            studentGrades.Add(90);

            // Display the updated contents of studentGrades
            foreach (int grade in studentGrades)
            {
                Console.WriteLine(grade);
            }
            studentGrades.Remove(78);

            // Display the updated contents of studentGrades after the removal.
            Console.Write("After Removal");
            foreach (int grade in studentGrades)
            {
                Console.WriteLine(grade);
            }
            int index = studentGrades.IndexOf(95);

            // Update the grade at the found index to 96.
            studentGrades[index] = 96;

            Console.WriteLine("Display the updated contents of studentGrades");

            // Display the updated contents of studentGrades.
            foreach (int grade in studentGrades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
