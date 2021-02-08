//-----------------------------------------------------------------------
// <copyright file="IDrawable.cs" company="FH WN">
//     Copyright (c) Thomas Horvath. All rights reserved.
// </copyright>
// <summary>This file contains the Idrawable logic.</summary>
//-----------------------------------------------------------------------
namespace Aufgabe2_Thomas_Horvath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The interface for this.
    /// </summary>
    public interface IDrawable
    {
        /// <summary>
        /// The draw method that needs to be implemented.
        /// </summary>
        /// <param name="renderer">Takes any renderer as input.</param>
        void Draw(IRenderer renderer);
    }
}