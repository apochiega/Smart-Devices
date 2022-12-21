//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using AdapterExample;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Principal
        /// </summary>
        public static void Main()
        {
            Plug plug = new Plug("4564");
            ISmartDevice SmartPlug = new Adapter(plug);
            Console.WriteLine(SmartPlug.GetStatus());
            SmartPlug.On();
        }
    }
}