//-----------------------------------------------------------------------
// <copyright file="Renderer.cs" company="FH WN">
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
    /// The class Renderer.
    /// </summary>
    public class Renderer : IRenderer
    {
        /// <summary>
        /// Draws all shapes from an array onto the console.
        /// </summary>
        /// <param name="drawable">Takes this as array input.</param>
        public void DrawAllShapes(IDrawable[] drawable)
        {
            for (int i = 0; i < drawable.Length; i++)
            {
                drawable[i].Draw(this);
            }
        }

        /// <summary>
        /// The logic for how to draw rectangles.
        /// </summary>
        /// <param name="rectangle">Takes a rectangle as input.</param>
        public void Draw(Rectangle rectangle)
        {
            Console.SetCursorPosition(rectangle.X, rectangle.Y);

            for (int i = 0; i < rectangle.Width; i++)
            {
                for (int j = 0; j < rectangle.Height; j++)
                {
                    Console.Write(rectangle.Symbol);
                }

                Console.SetCursorPosition(rectangle.X, rectangle.Y + i + 1);

                ////My answer to trying to avoid a scrollbar.
                ////Shapes would also keep getting drawn on the same coordinates without this at the moment.
                if (Console.CursorTop >= Console.LargestWindowHeight - 2)
                {
                    break;
                }
            }
        }

        /// <summary>
        /// The draw method for circles.
        /// </summary>
        /// <param name="circle">Takes a circle as input.</param>
        public void Draw(Circle circle)
        {
            int radius = (circle.Height + circle.Width) / 4;
            Console.SetCursorPosition(circle.X, circle.Y);

            //// A way to avoid half-drawn "circles".
            if (circle.X - (circle.Height / 2) < 0)
            {
            }

            for (int i = 0; i < circle.Height / 2; i++)
            {
                for (int j = 0; j < i * 2; j++)
                {
                    Console.Write(circle.Symbol);
                }

                Console.SetCursorPosition(circle.X - i - 1, circle.Y + i + 1);

                if (Console.CursorLeft < 1 || Console.CursorTop >= Console.LargestWindowHeight - 3)
                {
                    break;
                }
            }

            for (int i = 0; i < circle.Height / 2; i++)
            {
                if (Console.CursorLeft < 1 || Console.CursorTop >= Console.LargestWindowHeight - 3)
                {
                    break;
                }

                for (int j = circle.Height; j > i * 2; j--)
                {
                    Console.Write(circle.Symbol);
                }

                Console.SetCursorPosition(circle.X - (circle.Height / 2) + i + 1, circle.Y + i + (circle.Height / 2));

                if (Console.CursorLeft < 1 || Console.CursorTop >= Console.LargestWindowHeight)
                {
                    break;
                }
            }
        }

       /// <summary>
       /// The Draw method.
       /// </summary>
       /// <param name="triangle">Takes a triangle as input.</param>
        public void Draw(Triangle triangle)
        {
            Console.SetCursorPosition(triangle.X, triangle.Y);

            for (int i = 0; i < triangle.Height; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(triangle.Symbol);
                }

                Console.SetCursorPosition(triangle.X - i - 1, triangle.Y + i + 1);
                if (Console.CursorLeft < 1 || Console.CursorTop > Console.LargestWindowHeight - 3)
                {
                    break;
                }
            }
        }
    }
}