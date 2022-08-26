//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            var t1 = new Train("Train to London");
            var t2 = new Train("Train to London");
            var t3 = new Train("Runaway Train");
            System.Console.WriteLine(Train.count);
            System.Console.WriteLine(t1 == t2);
            System.Console.WriteLine(t2 == t3);
        }
    }
}