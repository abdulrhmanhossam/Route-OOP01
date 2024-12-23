using System.Drawing;

namespace Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            //foreach (WeekDays days in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(days);
            //} 
            #endregion

            #region Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //Console.WriteLine("Person Details: ");

            //var persons = new Person[3];

            //persons[0] = new Person { Name = "Ziad", Age = 22 };
            //persons[1] = new Person { Name = "Reem", Age = 23 };
            //persons[2] = new Person { Name = "Mousaa", Age = 18 };

            //foreach (var person in persons)
            //{
            //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            //} 
            #endregion

            #region Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //Console.WriteLine("Enter a season name (Spring, Summer, Autumn, Winter):");

            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Season season))
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid season.");
            //            break;
            //    }
            //} 
            #endregion

            #region Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            //Console.WriteLine("Permission Management:");
            //Permissions userPermissions = Permissions.None;

            //userPermissions |= Permissions.Read;
            //userPermissions |= Permissions.Write;
            //Console.WriteLine($"Current Permissions: {userPermissions}");

            //if ((userPermissions & Permissions.Write) == Permissions.Write)
            //{
            //    Console.WriteLine("Write permission exists.");
            //}

            //userPermissions &= ~Permissions.Write;
            //Console.WriteLine($"Permissions after removal: {userPermissions}");

            //if ((userPermissions & Permissions.Write) != Permissions.Write)
            //{
            //    Console.WriteLine("Write permission does not exist.");
            //}
            #endregion

            #region Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            //Console.WriteLine("Enter a color name (Red, Green, Blue):");
            //string inputColor = Console.ReadLine();

            //if (Enum.TryParse(inputColor, true, out Colors color))
            //{
            //    switch (color)
            //    {
            //        case Colors.Red:
            //        case Colors.Green:
            //        case Colors.Blue:
            //            Console.WriteLine($"{color} is a primary color.");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid color.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid color name.");
            //} 
            #endregion

            #region Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Console.WriteLine("Enter the coordinates for the first point (X Y):");
            //string[] point1Input = Console.ReadLine().Split(' ');
            //Point point1 = new Point(double.Parse(point1Input[0]), double.Parse(point1Input[1]));

            //Console.WriteLine("Enter the coordinates for the second point (X Y):");
            //string[] point2Input = Console.ReadLine().Split(' ');
            //Point point2 = new Point(double.Parse(point2Input[0]), double.Parse(point2Input[1]));

            //double distance = point1.DistanceTo(point2);
            //Console.WriteLine($"The distance between the two points is: {distance:F2}"); 
            #endregion

        }
    }
}
