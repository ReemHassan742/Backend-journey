using Assigments.Enums;
using Assigments.Structs;
using System.Drawing;

namespace Assigment
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1 
            //Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            /*
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
            */
            #endregion

            #region Task 2
            //Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            /*
            String[] Persons = new String[3];
            Persons[0] = "Name: John, Age: 30"; 
            Persons[1] = "Name: Alice, Age: 25";
            Persons[2] = "Name: Bob, Age: 28";
            foreach (String person in Persons)
            {
                Console.WriteLine(person);
            }
            */
            #endregion

            #region Task 3
            /*
            Console.Write("Enter a season: ");
            string input = Console.ReadLine();

            if (Enum.TryParse<Season>(input, true, out Season season))
            {
                string range = season switch
                {
                    Season.Spring => "March to May",      
                    Season.Summer => "June to August",    
                    Season.Autumn => "September to November", 
                    Season.Winter => "December to February",  
                    _ => "Unknown"
                };
                Console.WriteLine($"{season}: {range}");
            }
               else
               {
                Console.WriteLine("Invalid season!");
               }
            }
           }
            */
            #endregion

            #region Task 4
            /*Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
               Create Variable from previous Enum to Add and Remove Permission from variable, 
               check if specific Permission is existed inside variable
             */

            /*
            Permissions userPermissions = Permissions.Read | Permissions.Write;
            Console.WriteLine($"Initial Permissions: {userPermissions}");

            userPermissions |= Permissions.Execute;
            Console.WriteLine($"After Adding Execute : {userPermissions}");

            userPermissions &= ~Permissions.Write;
            Console.WriteLine($"After Removing Write : {userPermissions}");
            bool hasDeletePermission = (userPermissions & Permissions.Delete) == Permissions.Delete;
            Console.WriteLine($"Has Delete Permission: {hasDeletePermission}");
            
            if ((userPermissions & Permissions.Read) == Permissions.Read)
            {
                Console.WriteLine("User has Read permission.");
            }
            else
            {
                Console.WriteLine("User does not have Read permission.");
            }
            */
            #endregion

            #region Task 5
            //Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            /*
            Console.Write("Enter a color (Red, Green, Blue): ");
            String UserInput = Console.ReadLine();
            if (Enum.TryParse<Colors>(UserInput, true, out Colors color))
            {
                Console.WriteLine($"{color} is a primary color.");
            }
            else
            {
                Console.WriteLine("Invalid color!");
            }
            */
            #endregion

            #region Task 6
            //Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            /*
            Console.WriteLine("Enter details for Point 1:");
            Point point = ReadPoint();

            Console.WriteLine("Enter details for Point 2:");
            Point point2 = ReadPoint();

            double distance = CalculateDistance(point, point2);
            Console.WriteLine($"The distance between the points is: {distance}");

            static Point ReadPoint()
            {
                Point point= new Point();
                Console.Write("Enter X coordinate: ");
                point.X = int.Parse(Console.ReadLine());

                Console.Write("Enter Y coordinate: ");
                point.Y = int.Parse(Console.ReadLine());
                return point;
            }
            static double CalculateDistance(Point p1, Point p2)
            {
                int deltaX = p2.X - p1.X;
                int deltaY = p2.Y - p1.Y;
                return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            }
            */
            #endregion

            #region Task 7
            //Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            /*
            Person2[] people = new Person2[3];

            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter details for person {i + 1}:");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());

                people[i] = new Person2 { Name = name, Age = age };
            }

            
            Person2 oldest = people[0];
            for (int i = 1; i < 3; i++)
            {
                if (people[i].Age > oldest.Age)
                {
                    oldest = people[i];
                }
            }

            
            Console.WriteLine($"\nThe oldest person is: {oldest.Name}, Age: {oldest.Age}");
            */
            #endregion
        }
    }
}