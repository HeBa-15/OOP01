namespace Assigment
{

    #region WeekDays
    enum WeekDays
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
    #endregion

    
    enum Season
    {
        Spring, Summer, Autumn, Winter
    }

    enum Permission : byte
    {
        Read = 1, Write = 2, Delete = 4, Execute = 8
    }

    enum Colors
    {
        Red, Green, Blue
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1:Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.

            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays))) 
            //{
            //    Console.WriteLine(day);
            //}



            #endregion


            #region Q2:Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //Console.WriteLine("Enter the season:");
            //string season_ = Console.ReadLine();

            //if (Enum.TryParse(season_, true, out Season season))
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring Months: March to May");
            //            break;

            //        case Season.Summer:
            //            Console.WriteLine("summer  Months: June to August ");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("autumn  Months: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("winter  Months: December to February");
            //            break;
            //    }
            //}
            //else
            //    Console.WriteLine("invalid");

            #endregion


            #region Q4:Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

            Console.WriteLine("enter a color");
            string colorInput = Console.ReadLine();

            if (Enum.TryParse(colorInput, true,out Colors color))
            {
                if (color == Colors.Red || color == Colors.Green || color == Colors.Blue)
                {
                    Console.WriteLine("Primary Color");
                }
                else
                    Console.WriteLine("Not Primary Color");
            }
            else
                Console.WriteLine("invalid color");



            if (Enum.TryParse(colorInput, out Colors colors))
            {
                Console.WriteLine("Primary Color");

            }
            else
                Console.WriteLine("invalid color");


            #endregion


        }
    }
}