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
        //What You Can Write inside the Class?

        // 1. Fields(Attributes | Member Variables)
        // 2. Properties (Full, Automatic)
        // 3. Indexers (Special Property)
        // 4. Methods
        // 5. Operators
        // 6. Constructors
        // 7. Destructors
        // 8. Events
        // 9. Static Members (Static Fields , Static Properties ,Static Methods , Static Constructor)
        // 10. Nested Types (Classes , Structs,Interfaces , Enums and etc)



        /// Allowed Access Modifiers inside the class? 
        /// 1. private 
        /// 2. private protected
        /// 3. protected
        /// 4. internal
        /// 5. internal protected
        /// 6. public

       
        /// Default Access Modifier inside the class and struct is 'private'
        ///
    
    
    }

    class TypeC
    {
        public TypeC()
        {
            TypeA typeA = new TypeA();
        }
    }



    public struct TypeZ
    {
        /// What You Can Write inside the struct?
        /// 1. Fields(Attributes | Member Variables)
        /// 2. Properties (Full, Automatic)
        /// 3. Indexers (Special Property)
        /// 4. Methods
        /// 5. Operators
        /// 6. Constructors
        /// 7. Events
        /// 8. Nested Types (Classes , Structs,Interfaces , Enums and etc)



        // Allowed Access Modifiers inside the struct? 
        // 1. private
        // 2. internal
        //3. public


        /// Default Access Modifier inside the class and struct is 'private'
        ///

    }
}
