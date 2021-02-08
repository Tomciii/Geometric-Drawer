//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="FH WN">
//     Copyright (c) Thomas Horvath. All rights reserved.
// </copyright>
// <summary>This file contains the Shape Drawer Program.</summary>
//-----------------------------------------------------------------------
namespace Aufgabe2_Thomas_Horvath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The main class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main function that starts the program.
        /// </summary>
        /// <param name="args">Console Line arguments.</param>
        public static void Main(string[] args)
        {
            //// Not sure how to avoid scrollbars without it also having it create issues for drawing the shapes.
            Console.SetBufferSize(Console.LargestWindowWidth * 2, Console.LargestWindowHeight);
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Menu menu = new Menu();
            menu.Run();
        }
    }
}