using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlibrary
{
    public class TypeB
    {
        private  int x;
        internal int y;
        public   int Z;
        void fun01()
        {
            TypeB typeB = new TypeB();
            typeB.x = 12;//valid
            typeB.y = 13;//valid
            typeB.Z = 14;//valid
        }
    }
}
