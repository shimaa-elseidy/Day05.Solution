
namespace Demo
{
    internal class Program
    {
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


        }
    }
}