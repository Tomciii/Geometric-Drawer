//-----------------------------------------------------------------------
// <copyright file="Shape.cs" company="FH WN">
//     Copyright (c) Thomas Horvath. All rights reserved.
// </copyright>
// <summary>This file contains for the abstract class Shape.</summary>
//-----------------------------------------------------------------------
namespace Aufgabe2_Thomas_Horvath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The geometric shape class.
    /// </summary>
    public abstract class Shape : IDrawable
    {
        /// <summary>
        /// The coordinates of the shape.
        /// </summary>
        private int[] coords = new int[2];

        /// <summary>
        /// The X coordinate of a shape.
        /// </summary>
        private int x;

        /// <summary>
        /// The Y coordinate of a shape.
        /// </summary>
        private int y;

        /// <summary>
        /// The height of a shape.
        /// </summary>
        private int height;

        /// <summary>
        /// The width of a shape.
        /// </summary>
        private int width;

        /// <summary>
        /// The random char the shape draws.
        /// </summary>
        private char symbol;

        /// <summary>
        /// An array of chars for potential symbols the shape can use.
        /// </summary>
        private char[] possibleSymbols = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        /// <summary>
        /// Instance of a Random Object.
        /// </summary>
        private Random random = new Random();

        /// <summary>
        /// Initializes a new instance of the Shape class.
        /// </summary>
        public Shape()
        {
                this.x = this.random.Next(1, Console.LargestWindowWidth * 3 / 4);
                this.y = this.random.Next(1, 15);
                this.height = this.random.Next(3, Console.LargestWindowHeight * 2);
                this.width = this.random.Next(3, Console.LargestWindowHeight * 2);
                this.symbol = this.possibleSymbols[this.random.Next(this.possibleSymbols.Length)];
        }

        /// <summary>
        /// Gets the symbol of this shape.
        /// </summary>
        /// <value>The value of symbol.</value>
        public char Symbol
        {
            get
            {
                return this.symbol;
            }
        }

        /// <summary>
        /// Gets the value of x.
        /// </summary>
        /// <value>The value of X.</value>
        public int X
        {
            get
            {
                return this.x;
            }
        }

        /// <summary>
        /// Gets the value of y.
        /// </summary>
        /// <value>The value of y.</value>
        public int Y
        {
            get
            {
                return this.y;
            }
        }

        /// <summary>
        /// Gets the value of height.
        /// </summary>
        /// <value>The value of height.</value>
        public int Height
        {
            get
            {
                return this.height;
            }
        }

        /// <summary>
        /// Gets the value of width.
        /// </summary>
        /// <value>The value of width.</value>
        public int Width
        {
            get
            {
                return this.width;
            }
        }

      /// <summary>
      /// Draws the shape.
      /// </summary>
      /// <param name="renderer">Takes a renderer as input and draws this.</param>
        public abstract void Draw(IRenderer renderer);
    }
}