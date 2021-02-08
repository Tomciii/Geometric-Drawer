//-----------------------------------------------------------------------
// <copyright file="IRenderer.cs" company="FH WN">
//     Copyright (c) Thomas Horvath. All rights reserved.
// </copyright>
// <summary>This file contains the Renderer logic.</summary>
//-----------------------------------------------------------------------
namespace Aufgabe2_Thomas_Horvath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The interface for renderers.
    /// </summary>
    public interface IRenderer
    {
        /// <summary>
        /// The draw method for triangles.
        /// </summary>
        /// <param name="triangle">Takes a triangle as input.</param>
        void Draw(Triangle triangle);

        /// <summary>
        /// The draw method for rectangles.
        /// </summary>
        /// <param name="rectangle">Takes a rectangle as input.</param>
        void Draw(Rectangle rectangle);

        /// <summary>
        /// The draw method for circles.
        /// </summary>
        /// <param name="circle">Takes a circle as input.</param>
        void Draw(Circle circle);
    }
}
