using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01
{
    internal struct Point
    {

        #region Struct

        #region Fields

        //Attributes

        public int X; // 4 bytes
        public int Y; // 4 bytes

        #endregion

        #region Constructor

        // Constructor: is a Special Function for 2 reasons
        //               1. Named always with the same Name of its Class or Struct
        //               2. Has No Return

        // Parameterless Struct Constructor
        // By Default In Struct, Compiler Will Always Generate the Parameterless Constructor
        // This Constructor Will Initialize each and every struct object Attribute with its default value.

        public Point()
        {
            X = default; // 0
            Y = default; // 0
        }

        public Point(int Number)
        {
            this.X = this.Y = Number;
        }

        public Point(int _X, int _Y)
        {
            /* this. */
            X = _X;
            Y = _Y;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        #endregion

        #endregion


    }
}
