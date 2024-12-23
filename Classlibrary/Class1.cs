using System;

namespace Classlibrary
{

    // Access Modifiers : C# keyword Indicate Accessability Scope.
    // 1. private
    // 2. protected
    // 3. private protected
    // 4. internal
    // 5. internal protected
    // 6. public
    //=============================================================
    // we can write inside namespace 4 things
    // 1.class
    // 2.struct
    // 3.Enum
    // 4.Interface
    //=============================================================
    //Access Modifiers that we can write in Namespace:
    // 1. internal :Accessable inside the same project.
    // 2. public   :Accessable everywhere.


    // Default Access Modifier into Name space is internal.

    //==============================================================
    // we can write inside Class or Struct 4 things
    //  1.Attributes [filed - member variable].
    //  2.Properties [Full property - special property (indexer) - Automatic property ].
    //  3.Methods( Functions ).
    //  4.Event.
    //=============================================================
    //Access Modifiers that we can write in Class:
    // 1. private
    // 2. protected
    // 3. private protected
    // 4. internal
    // 5. internal protected
    // 6. public
    //=============================================================
    //Access Modifiers that we can write in Struct:
    // 1. private  : Accessable inside the same class.
    // 2. internal : Accessable inside the same project.
    // 3. public   > Accessable Every where.

    //=============================================================
    // Default Access Modifier into class or struct is private.
    //=============================================================
    // whate can we write into interface ====>
    // 1. signature of methods (return type - name - parameter)
    // 2. signature of property
    // 3. default implemented methods
    // interface uses all access modifiers except "private"

    // Default Access Modifier into interface is public.
    //=============================================================
    //class TypeA
    //    {
    //        void fn01()
    //        {
    //            TypeB typeB = new TypeB();
            
    //        //typeB.x = 12;//In-Valid
    //        typeB.y = 13;//Valid
    //        typeB.Z = 14;//Valid
    //    }
    //    }
    }

