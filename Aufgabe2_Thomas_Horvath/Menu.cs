//-----------------------------------------------------------------------
// <copyright file="Menu.cs" company="FH WN">
//     Copyright (c) Thomas Horvath. All rights reserved.
// </copyright>
// <summary>This file contains the Menu logic.</summary>
//-----------------------------------------------------------------------
namespace Aufgabe2_Thomas_Horvath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Contains the Menu logic for the geometric drawer.
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// The method that contains the run method for the menu.
        /// </summary>
        public void Run()
        {
            ShapeManager shapeManager = new ShapeManager();
            Renderer renderer = new Renderer();
            ConsoleKey input;
            ConsoleKey[] inputs = { ConsoleKey.F1, ConsoleKey.F2, ConsoleKey.F3, ConsoleKey.F8, ConsoleKey.F9, ConsoleKey.F10, ConsoleKey.F12 };

            do
            {
                Console.SetCursorPosition(0, 0);
                input = Console.ReadKey().Key;
                Console.Clear();

                if (input.Equals(inputs[0]))
                {
                    shapeManager.Drawables = shapeManager.AddShape(shapeManager.Drawables, new Rectangle());
                }
                else if (input.Equals(inputs[1]))
                {
                    shapeManager.Drawables = shapeManager.AddShape(shapeManager.Drawables, new Triangle());
                }
                else if (input.Equals(inputs[2]))
                {
                    shapeManager.Drawables = shapeManager.AddShape(shapeManager.Drawables, new Circle());
                }
                else if (input.Equals(inputs[3]))
                {
                    shapeManager.Drawables = shapeManager.ShuffleShapes(shapeManager.Drawables);
                }
                else if (input.Equals(inputs[4]))
                {
                    shapeManager.Drawables = shapeManager.RemoveShape(shapeManager.Drawables);
                }
                else if (input.Equals(inputs[5]))
                {
                    inputs = this.ChangeKeys(input);
                }

                Console.Clear();

                try
                {
                    renderer.DrawAllShapes(shapeManager.Drawables);
                }
                catch (Exception)
                {
                    Console.WriteLine(string.Empty);
                }
            }
            while (!input.Equals(inputs[6]));
        }

        /// <summary>
        /// Changes the Keys of the program.
        /// </summary>
        /// <param name="input">Takes a input for changing keys.</param>
        /// <returns>Returns a console key array.</returns>
        private ConsoleKey[] ChangeKeys(ConsoleKey input)
        {
            ConsoleKey[] result = new ConsoleKey[7];
            ConsoleKey[] possibleKeys = { ConsoleKey.F1, ConsoleKey.F2, ConsoleKey.F3, ConsoleKey.F4, ConsoleKey.F5, ConsoleKey.F6, ConsoleKey.F7, ConsoleKey.F8, ConsoleKey.F9, ConsoleKey.F10, ConsoleKey.F11, ConsoleKey.F12 };

            for (int i = 0; i < result.Length; i++)
            {
                Console.Clear();
                Console.WriteLine("Choose a Function Key: ");
           
                while (result.Contains(input) || !possibleKeys.Contains(input)) 
                { 
                input = Console.ReadKey().Key;
                }

                result[i] = input;
            }

            return result;
        }
    }
}
