//-----------------------------------------------------------------------
// <copyright file="Rectangle.cs" company="FH WN">
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
    /// The Rectangle class.
    /// </summary>
    public class Rectangle : Shape
    {
        /// <summary>
        /// Initializes a new instance of the Rectangle class.
        /// </summary>
        public Rectangle()
        {
        }

        /// <summary>
        /// A draw method for things.
        /// </summary>
        /// <param name="renderer">Renderer as input.</param>
        public override void Draw(IRenderer renderer)
        {
            renderer.Draw(this);
        }
    }
}