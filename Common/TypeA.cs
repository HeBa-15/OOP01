using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    //What You Can Write Inside the Namespace?
    //1. Class
    //2. Struct [stands for structure]
    //3. Interface
    //4. Enum
    //5. Delegate
    //6. Record [C# 9.0 NEW Feature (.NET 5.0)]
    //7. Nested Namespace


    ///Allow Access Modifiers inside the Namespace?
    ///1. internal [Default Access Modifiers]
    ///2. public
    ///3. file [C# 11.0 Feature (.NET 7.0)]


    public class TypeA
    {
    }

    class TypeC
    {
        public TypeC()
        {
            TypeA typeA = new TypeA();
        }
    }
}
