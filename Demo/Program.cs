using Classlibrary;

namespace Demo
{
    internal class Program
    {
        #region DoSomeCode()
        //static void DoSomeCode()
        //{
        //try
        //{
        //    int x, y, z;
        //    x = int.Parse(Console.ReadLine());
        //    y = int.Parse(Console.ReadLine());
        //    z = x / y;
        //    int[] arr = { 1, 2, 3, 4, };
        //    arr[99] = 16;
        //}
        //catch (FormatException ex) 
        //{
        //    Console.WriteLine(ex.Message);

        //}
        //catch(DivideByZeroException x)
        //{
        //    Console.WriteLine(x.Message);
        //}
        //catch(IndexOutOfRangeException e){
        //    Console.WriteLine(e.Message);
        //}
        //====================================
        //catch (Exception ex) 
        //{
        //    Console.WriteLine(ex);
        //} 
        //finally
        //{
        //  Console.WriteLine("any thing");
        //}
        // finally for 1. Release 2.Deallocate 3.Disconnect 4.Dispose  ==> for unmanaged resource(database or data in files)
        #endregion
        #region DoSomeProtectiveCode()
        //static void DoSomeProtectiveCode()
        //{
        //    int X, Y, Z;
        //    bool flag;
        //    try
        //    {
        //        do
        //        {
        //            Console.WriteLine("enter first num : ");
        //            flag = int.TryParse(Console.ReadLine(), out X);
        //        }
        //        while (flag == false);
        //        do
        //        {
        //            Console.WriteLine("enter sec num : ");
        //            flag = int.TryParse(Console.ReadLine(), out Y);
        //        }
        //        while (flag == false || Y == 0);

        //        Z = X / Y;
        //        Console.WriteLine(Z);

        //        int[] arr = { 1, 2, 3, 4, 5, 6 };

        //        if (arr?.Length >= 99)
        //        {
        //            Console.WriteLine(arr[99] = 66);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
            

        //}

        #endregion
        static void Main(string[] args)
        {
            #region Boxing & UnBoxing
            // Boxing   : casting (convert) from value type to reference type.
            // UnBoxing : casting (convert) from reference type to value type.
            //========================================Boxing======================================================
            //object o1;
            // o1; refer to instance of object or any data type as the object is the parent of any data type.
            //o1 = 3  ;     // cast from value type(Int 3) to reference type[Object] ===========>Boxing
            //o1 = 3.5;     // cast from value type(Double 3.5) to reference type[Object] ===========>Boxing
            //o1 = "A";      // cast from value type(char A) to reference type[Object] ===========>Boxing
            //o1 = true;     // cast from value type(Boolean) to reference type[Object] ===========>Boxing
            //o1 = "shimaa"; // cast from value type(String) to reference type[Object] ===========>Boxing
            //o1 = new DateTime(); // cast from value type(DateTime) to reference type[Object] ===========>Boxing
            //Builtin Struct ===> DateTime().
            //int X = 3;
            //o1 = X;
            //imlicit casting , safe casting as converting from integer to object doesn't affect of original value .
            //Boxing
            //parent = child ====> child is the parent.
            //========================================Unboxing=====================================================
            // unboxing
            //object o1 = 3 ;
            //int x = o1; // xxxxxxxxxxx
            //int x = (int)o1;
            // Explicit Casting
            // unsafe casting (may throw or making exception)
            #endregion
            #region Nullable Value Type
            //int X = null; ==>xxxxxx not valid
            //         <===Nullable integer===>
            // nullable value type ===>value type allow null as valid value.
            //int? age = 20; // nullable<int> allow int value or null as valid value
            //age = null;
            //double? salary = 4000.5;//allow double value or null as valid value
            //salary = null;
            //int x = 6;
            //int? y = 7;nullable<int>
            //int x = 4;
            //int? y = 5;
            //y ==> nullable <int> allow int we null
            //y = x;//implicit casting 
            //int? x = 5;
            //x = null;
            // int y;
            //int y = x;// y allow int only
            //int y =(int) x;// Explicit casting as i forced el x to be from type int , may throw exception.
            // Devensive Code
            //if (x!=null)
            //{
            //     y = (int)x;
            //}
            //else
            //{
            //    y = 0;
            //}
            //Console.WriteLine(y);
            //=============================
            //if (x is not null)
            //{
            //    y = (int)x;
            //}
            //else
            //{
            //    y = 0;
            //}
            //=============================
            //if (x.HasValue)
            //{
            //    y = x.Value;
            //}
            //else
            //{
            //    y = 0;
            //}
            //============================
            //y = x.HasValue? x.Value:0 ;
            //y = x is not null ? x.Value : 0;
            //============================
            //     Null Coalescing Operator ==>??
            // y = x ?? 0; // syntax sugar from y = x is not null ? x.Value : 0;
            // Console.WriteLine(y);

            #endregion
            #region Nullable Reference type
            // c# 10 .net 6
            // default value of ref is null
            // string   Name = null;//Required
            //string? Name02 = null;//Nullable optional
            //Console.WriteLine(Name.Length);
            //Console.WriteLine(Name02.Length);
            #endregion
            #region Null Propagation Operator ?
            //double x = default; //0
            //Console.WriteLine(x);
            //char x = default;// space
            //Console.WriteLine(x);

            //=====default value of ref type = null
            //int[] arr = default;//null
            //int[] arr = { 1, 2, 5 };
            //for (int i = 0; arr is not null &&i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            /// best practice 
            //if (arr is not null )
            //{
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }
            //} 
            //for (int i = 0; i < arr?.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //int? len = arr?.Length;
            //int len = arr?.Length is not null ? arr.Length : 0;
            //int len = arr?.Length ?? 0;

            //Console.WriteLine(len);
            #endregion
            #region Exception Handling & Protective code
            //  DoSomeCode();
            // ==================builtin class (exception)====================
            // 1. SystemException.
            //1.1 formatException.
            //1.2 IndexOutOfRangeException.
            //1.3 NullReferenceException.
            //1.4 ArithmeticException.
            //1.4.1 OverflowException.
            //1.4.2 DivideByZeroException.
            // 2. ApplicationException. 
            //======================================Handling=========================
            //DoSomeProtectiveCode();
            #endregion
            #region Access Modifiers
            TypeB typeB = new TypeB();
            //typeB.x = 12;// In-Valid
            //typeB.y = 13;//In-Valid
            //typeB.Z = 14;//valid

            #endregion
        }

    } 
}
