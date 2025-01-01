 global using Common;
using System;

namespace OOP01
{



    class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public Gender Gender { get; set; }
    }


    enum Branch : byte
    {
        Dokki = 200, Maadi , NasrCity , Alex = 253,BNS,SmartVillage
    }

    enum Grade : byte
    {
        A, B, C, D, E, F // Labels
    }


    enum Gender
    {
        Male=1, Female=2
    }

    //byte = 8 bites [0:255]
    [Flags]
    enum Permission : byte
    {
        Read = 1, Write = 2, Delete = 4, Update = 8, Test = 16, XX = 32, YY = 64, ZZ = 128
    }


    internal class Program
    {
        
        public static void Run( BMWCar Car)
        {
            Car.Accelerate();
        }
        static void Main(string[] args)
        {
            #region Access Modifires

            TypeA typeA = new TypeA();

            // typeA.x = 10; [invalid] x is inaccessible due to its protection level "private"
            // typeA.y = 10; [invalid] y is inaccessible due to its protection level "internal"
            // typeA.z = 30;  //[valid]  z is public


            TypeA obj = new TypeA();
            // obj.x = 1; " x is private "
            // obj.y = 2; " y is private "
            // obj.z = 3;

            #endregion

            #region Enum

            #region part 01

            /// Person person = new Person();
            /// person.Id = 1001;
            /// person.Name = "Ahmed Nasr";
            /// person.Salary = 10_000;
            /// person.Gender = Gender.Male;

            /// Gender myGender = Gender.Female;
            /// Console.WriteLine(myGender);


            // Grade myGrade = Grade.A;

            /// if (myGrade == Grade.A) 
            ///    Console.WriteLine(" :) ");
            /// else
            ///    Console.WriteLine(" :( ");


            /// Grade myGrade;
            /// myGrade = (Grade)3;
            /// myGrade = (Grade)10;
            /// myGrade = (Grade)255;


            /// Console.WriteLine(myGrade); // 10

            #endregion

            #region Part 02 Casting
            // Gender myGender;
            // myGender = /* UnBoxing */(Gender) Enum.Parse(typeof(Gender) /* Boxing */ , "male", true);
            // myGender = Enum.Parse<Gender>("male", true);


            // Enum.TryParse(typeof(Gender), "Male", true, out object? result /*Boxing*/ );
            // myGender = (Gender) /* UnBoxing */ (result ?? Gender.Male);


            //Enum.TryParse/*<Gender>*/("Male", true, out myGender);

            // Console.WriteLine(myGender);

            #endregion


            // part17
            // Permission myPermissions = Permission.Read;
            // myPermissions = (Permission)255;
            // Console.WriteLine(myPermissions);

            /// part18
            /// Permission MyP = (Permission)3; // Write, Read
            /// MyP |= Permission.Execute; // MyP | Permission.Execute; 3[0011] | 4[0100] = 7
            /// MyP &= ~(Permission.Read); // 0010 => 1101 & 0111 = 0101
            /// MyP ^= Permission.Execute;
            /// MyP ^= Permission.Execute;
            /// Console.WriteLine(MyP); // Write
            /// 





            #endregion


            #region Struct
            Point P1;
            // Declare for Object of type "Point".
            // CLR Will Allocate 8 UnIntialized Bytes at STACK.

            P1 = new Point();
            // new -- > is just for the Constructor Selection that will initialize the struct object attributes 


            Console.WriteLine(P1.X);
            Console.WriteLine(P1.Y);


            Point point = new Point(1, 2);
            Console.WriteLine(point.ToString()); // Output: (1, 2)
            #endregion


        }
    }
}