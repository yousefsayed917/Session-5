using System.ComponentModel;
using System.Runtime.Serialization;

namespace Session_5_Assignment
{
    enum WeekDays
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
    enum Season
    {
        Spring, Summer, Autumn, Winter
    }
    enum Permissions
    {
        Read, write, Delete, Execute
    }
    enum Colors
    {
        Red, Green, Blue
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            //for (WeekDays i = WeekDays.Monday; i < WeekDays.Sunday; i++)
            //{
            //    WeekDays day = (WeekDays)i;
            //    Console.WriteLine(day);
            //}
            #endregion
            #region Q2
            //Person p1 = new Person("yousef", 22);
            //Person p2 = new Person("mohamed", 23);
            //Person p3 = new Person("Ahmed", 23);
            //Person[] arr = { p1, p2, p3 };
            //foreach (Person item in arr)
            //{
            //    Console.WriteLine($"Name is {item.Name}\t Age is {item.Age}");
            //}
            #endregion
            #region Q3
            //string SeaSon;
            //bool flag;
            //Season season;
            //do
            //{
            //    Console.WriteLine("Enter Season Name To Get Month Range Of This Season");
            //    Console.WriteLine("Spring, Summer, Autumn, Winter");
            //    SeaSon = Console.ReadLine()!;
            //    if (SeaSon != null && Enum.TryParse(SeaSon, out season))
            //    {
            //        switch (season)
            //        {
            //            case Season.Spring:
            //                Console.WriteLine("Spring: March To May");
            //                break;
            //            case Season.Summer:
            //                Console.WriteLine("Summer: June To August");
            //                break;
            //            case Season.Autumn:
            //                Console.WriteLine("Autumn: September to November");
            //                break;
            //            case Season.Winter:
            //                Console.WriteLine("Winter: December to February");
            //                break;
            //            default:
            //                Console.WriteLine("Invalid Input");
            //                break;
            //        }
            //        flag = true;
            //    }
            //    else
            //        flag = false;
            //} while (!flag);
            #endregion
            #region Q4

            #endregion
            #region Q5
            //string Color;
            //bool flag;
            //Colors color;
            //do
            //{
            //    Console.WriteLine("Enter A Color To Know It Is Primary Color Or Not");
            //    Color = Console.ReadLine()!;
            //    if (Color != null && Enum.TryParse(Color, out color))
            //    {
            //        switch (color)
            //        {
            //            case Colors.Red or Colors.Blue or Colors.Green:
            //                Console.WriteLine($"{color} is a primary color ");
            //                break;
            //            default:
            //                Console.WriteLine($"{color} is not a primary color");
            //                break;
            //        }
            //        flag = true;
            //    }
            //    else
            //        flag = false;
            //} while (!flag);
            #endregion
            #region Q6
            //bool flag;
            //Double x1,y1,x2,y2;
            //do
            //{
            //    Console.WriteLine("Enter The Value Of x in First Point");
            //    flag = Double.TryParse(Console.ReadLine()!, out x1);
            //    Console.WriteLine("Enter The Value Of y in First Point");
            //    flag = Double.TryParse(Console.ReadLine()!, out y1);
            //    Console.WriteLine("Enter The Value Of x in Second Point");
            //    flag = Double.TryParse(Console.ReadLine()!, out x2);
            //    Console.WriteLine("Enter The Value Of y in Second Point");
            //    flag = Double.TryParse(Console.ReadLine()!, out y2);
            //} while (!flag);
            //Point p1 = new Point(x1, y1);
            //Point p2 = new Point(x2, y2);
            //Double Distance = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));
            //Console.WriteLine($"Distance = {Distance}");
            #endregion
            #region Q7
            //bool flag;
            //int Age1, Age2, Age3;
            //string Name1, Name2, Name3;
            //do
            //{
            //    Console.WriteLine($"Enter The Name Of First Person ");
            //    Name1 = Console.ReadLine()!;
            //    Console.WriteLine("Enter The Age Of First Person");
            //    flag = int.TryParse(Console.ReadLine()!, out Age1);
            //} while (!flag);
            //do
            //{
            //    Console.WriteLine($"Enter The Name Of Second Person ");
            //    Name2 = Console.ReadLine()!;
            //    Console.WriteLine("Enter The Age Of Second Person");
            //    flag = int.TryParse(Console.ReadLine()!, out Age2);
            //} while (!flag);
            //do
            //{
            //    Console.WriteLine($"Enter The Name Of Third Person ");
            //    Name3 = Console.ReadLine()!;
            //    Console.WriteLine("Enter The Age Of Third Person");
            //    flag = int.TryParse(Console.ReadLine()!, out Age3);
            //} while (!flag);

            //Person p1 = new Person(Name1,Age1);
            //Person p2 = new Person(Name2,Age2);
            //Person p3 = new Person(Name3,Age3);

            //if (p1.Age > p2.Age && p1.Age < p3.Age)
            //    Console.WriteLine($"The Oldest Person Name :{p3.Name} \tAge : {p3.Age}");
            //else if (p1.Age > p2.Age && p1.Age > p3.Age)
            //    Console.WriteLine($"The Oldest Person Name :{p1.Name} \tAge : {p1.Age}");
            //else
            //    Console.WriteLine($"The Oldest Person Name :{p2.Name} \tAge : {p2.Age}");
            #endregion
        }
    }
}
