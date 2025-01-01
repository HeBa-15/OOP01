namespace Assigment
{

    #region WeekDays
    public enum WeekDays
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
    #endregion

    
    public enum Season
    {
        Spring, Summer, Autumn, Winter
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

            Console.WriteLine("Enter a season:");
            string seasonM = Console.ReadLine();

            if (Enum.TryParse(seasonM, true, out Season season))
            {
                switch (season)
                {
                    case Season.Spring:
                        Console.WriteLine("Spring Months: March to May");
                        break;

                    case Season.Summer:
                        Console.WriteLine("Spring Months: June to Augest");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Spring Months: September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Spring Months: December to Febraury");
                        break;
                }
            }
            else
                Console.WriteLine("invalid");

            #endregion

        }
    }
}