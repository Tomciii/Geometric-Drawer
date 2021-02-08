//-----------------------------------------------------------------------
// <copyright file="Circle.cs" company="FH WN">
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
    public class Circle : Shape
    {
        /// <summary>
        /// Initializes a new instance of the Circle class.
        /// </summary>
        public Circle()
        {
        }

       /// <summary>
       /// Draw method.
       /// </summary>
       /// <param name="renderer">Takes renderer as input.</param>
        public override void Draw(IRenderer renderer)
        {
            renderer.Draw(this);
        }
    }
}
