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
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
            #endregion
        }
    }
}


    

