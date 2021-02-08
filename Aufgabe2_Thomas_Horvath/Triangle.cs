//-----------------------------------------------------------------------
// <copyright file="Triangle.cs" company="FH WN">
//     Copyright (c) Thomas Horvath. All rights reserved.
// </copyright>
// <summary>This file contains Rectangle class.</summary>
//-----------------------------------------------------------------------
namespace Aufgabe2_Thomas_Horvath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The Triangle class.
    /// </summary>
    public class Triangle : Shape
    {
        /// <summary>
        /// Initializes a new instance of the Triangle class.
        /// </summary>
        public Triangle()
        {
        }

       /// <summary>
       /// How to draw things.
       /// </summary>
       /// <param name="renderer">Takes an array as input.</param>
        public override void Draw(IRenderer renderer)
        {
            renderer.Draw(this);
        }
    }
}
