using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB
    {

        public TypeB() 
        {
            TypeA typeA = new TypeA();
            // typeA.x = 10; [invalid] x is inaccessible due to its protection level "private"
            typeA.y = 20; // [valid]  y is internal && the object is declared inside the same project  

            typeA.z = 30;  //[valid]  z is public
        }
    }
}
