namespace Assignment05
{
    #region Enum Q01
    //public enum WeekDays
    //{
    //    Mon,
    //    Tus,
    //    Wen,
    //    Thur,
    //    Fri,
    //    Sat,
    //    Sun
    //}
    #endregion
    #region Enum02
    //public enum Season
    //{
    //    Spring,
    //    Summer, 
    //    Autumn, 
    //    Winter
    //}
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q01
            /*
             1-	Create an enum called "WeekDays" with the days of 
                the week (Monday to Sunday) as its members. Then, 
                write a C# program that prints out all the days of the week using this enum.
             */
            //int Len = Enum.GetValues(typeof(WeekDays)).Length;
            //for (int i = 0; i < Len; i++)
            //{
            //    WeekDays day = (WeekDays) i;
            //    Console.WriteLine(day);
            //}
            ///=======================Another Solution========================================
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
             //   Console.WriteLine(day);
            //}
            #endregion
            #region Q02
            /*
             2.	Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members
                Write a C# program that takes a season name as input from the user and displays the 
                corresponding month range for that season. 
                Note range for seasons ( spring march to may , summer june to august , 
                autumn September to November , winter December to February)
             */
            //Console.WriteLine("Enter Season Name (Spring, Summer, Autumn, Winter) : ");
            //string input = Console.ReadLine();
            //if (Enum.TryParse(input,true,out Season season))
            //{
            //    if (season == Season.Spring)
            //    {
            //        Console.WriteLine("spring : march to may");
            //    }
            //    else if (season == Season.Summer)
            //    {
            //        Console.WriteLine("summer : june to august ");
            //    }
            //    else if (season == Season.Autumn)
            //    {
            //        Console.WriteLine("autumn : September to November");
            //    }
            //    else if (season == Season.Winter)
            //    {
            //        Console.WriteLine("winter : December to February");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid Season.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid season name.");
            //}
            #endregion

        }
    }
}


    

