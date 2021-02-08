//-----------------------------------------------------------------------
// <copyright file="ShapeManager.cs" company="FH WN">
//     Copyright (c) Thomas Horvath. All rights reserved.
// </copyright>
// <summary>This file contains the ShapeManager.</summary>
//-----------------------------------------------------------------------
namespace Aufgabe2_Thomas_Horvath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The ShapeManager Class.
    /// </summary>
    public class ShapeManager
    {
        /// <summary>
        /// An Array for this.
        /// </summary>
        private IDrawable[] drawable;

        /// <summary>
        /// Initializes a new instance of the ShapeManager class.
        /// </summary>
        public ShapeManager()
        {
            this.drawable = new IDrawable[0];
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public IDrawable[] Drawables
        {
            get
            {
                return this.drawable;
            }

            set
            {
                this.drawable = value;
            }
        }

        /// <summary>
        /// Removes an element from a shape array.
        /// </summary>
        /// <param name="drawable">The array it modifies.</param>
        /// <returns>Returns a modified array.</returns>
        public IDrawable[] RemoveShape(IDrawable[] drawable)
        {
            if (drawable.Length < 1)
            {
                return drawable;
            }

            IDrawable[] result = new IDrawable[drawable.Length - 1];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = drawable[i];
            }

            return result;
        }

        /// <summary>
        /// Randomizes the order of the shapes.
        /// </summary>
        /// <param name="drawable">Takes this shape array as input.</param>
        /// <returns>Returns a new shape array.</returns>
        public IDrawable[] ShuffleShapes(IDrawable[] drawable)
        {
            IDrawable[] result = new IDrawable[drawable.Length];
            result = drawable;
            Random random = new Random();
            try
            {
                for (int i = drawable.Length - 1; i > 0; i--)
                {
                    int randomNumber = random.Next(0, i + 1);
                    IDrawable newShape = drawable[i];
                    drawable[i] = drawable[randomNumber];
                    drawable[randomNumber] = newShape;
                }

                return result;
            }
            catch (Exception)
            {
                return drawable;
            }
        }

        /// <summary>
        /// Adds a shape to a shape array.
        /// </summary>
        /// <param name="drawable">The shape array as input.</param>
        /// <param name="shape">The shape that gets added.</param>
        /// <returns>Returns a new shape array.</returns>
        public IDrawable[] AddShape(IDrawable[] drawable, Shape shape)
        {
            IDrawable[] result = new IDrawable[drawable.Length + 1];

            if (drawable.Length == 0)
            {
                result[0] = shape;
            }
            else
            {
                for (int i = 0; i < drawable.Length; i++)
                {
                    result[i] = drawable[i];
                }

                result[drawable.Length] = shape;
            }

            return result;
        }
    }
}