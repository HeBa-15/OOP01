 global using Common;
using System;

namespace OOP01
{
    internal class Program
    {

        public static void Run( BMWCar Car)
        {
            Car.Accelerate();
        }
        static void Main(string[] args)
        {
            TypeA typeA = new TypeA();

            // typeA.x = 10; [invalid] x is inaccessible due to its protection level "private"
            // typeA.y = 10; [invalid] y is inaccessible due to its protection level "internal"
               typeA.z = 30;  //[valid]  z is public

        }
    }
}