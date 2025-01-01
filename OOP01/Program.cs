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
        Male, Female
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

            #endregion

        }
    }
}