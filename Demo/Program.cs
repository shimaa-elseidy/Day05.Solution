using System.Security;

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
    #region Enum03
    //[Flags]
    //public enum Permissions
    //{
    //    none=0,
    //    Read=8, 
    //    write=4, 
    //    Delete=2, 
    //    Execute=1
    //}
    #endregion
    #region Enum04
    //public enum Colors
    //{
    //    Red, 
    //    Green, 
    //    Blue
    //}
    #endregion
    internal class Program
    {
        #region Permission fn
        //static void CheckPermission(Permissions userPermissions, Permissions permissionToCheck)
        //{ 
        //    if (userPermissions.HasFlag(permissionToCheck))
        //    {
        //        Console.WriteLine($"{permissionToCheck}  permission exists.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{permissionToCheck} permission does not exist.");
        //    }
        //}
        #endregion
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
            #region Q03
            /* 4- Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
                  Create Variable from previous Enum to Add and Remove Permission from variable, 
                  check if specific Permission is existed inside variable.
            */
            //Permissions permissions = Permissions.none;

            //permissions |= Permissions.Read;     
            //permissions |= Permissions.write;    
            //permissions |= Permissions.Delete;  
            //permissions |= Permissions.Execute;  
            //Console.WriteLine("Current Permissions: " + permissions);

            // Check for specific permission  
            //CheckPermission( permissions, Permissions.Read);     
            //CheckPermission( permissions,Permissions.Delete);

            // Remove permission  
            //permissions &= ~ Permissions.write; // Remove Write permission  
            //Console.WriteLine("Current Permissions after removal: " + permissions);

            //after removal  
            //CheckPermission(permissions, Permissions.write); //false  
            #endregion
            #region Q04
            /*
             5. Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. 
                Write a C# program that takes a color name as input from the user and displays a message 
                indicating whether the input color is a primary color or not.
             */
           // Console.WriteLine("Enter Color Name (Red, Green, Blue):");
           // string input = Console.ReadLine();

            //if (Enum.TryParse(typeof(Colors), input, true, out var color))
            //{
            //    Console.WriteLine($"{input} is a primary color.");
            //}
            //else
            //{
            //    Console.WriteLine($"{input} is not a primary color.");
            //}
            //==============another solution===========================================================
            //if (Enum.TryParse(input, true, out Colors InputColor))
            //{
            //    if (InputColor==Colors.Green | InputColor ==Colors.Red | InputColor == Colors.Blue )
            //    {
            //        Console.WriteLine($"{InputColor} Is a Primary color");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{InputColor} Isn't a Primary color");
            //    }
            //}
            //else
            //{

            //    Console.WriteLine("Enter Valid Color");
            //}
            #endregion

        }
    }
}


    

