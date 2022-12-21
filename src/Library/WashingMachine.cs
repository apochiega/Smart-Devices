//-------------------------------------------------------------------------
// <copyright file="Song.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------
using System;

namespace AdapterExample
{
    /// <summary>
    /// Un lavarropas inteligente
    /// </summary>
    public class WashingMachine: ISmartDevice
    {
        /// <summary>
        /// Crea una nueva lavarropas.
        /// </summary>
        /// <param name="id">ID del dispositivo.</param>
        /// <returns>El lavarropas recién creada.</returns>
        public WashingMachine(string id)
        {
            this.id = id;
            this.status = "off";
        }

        /// <summary>
        /// .
        /// </summary>
        /// <returns>El ID del dispositivo.</returns>
        public string id { get; }

          /// <summary>
        /// .
        /// </summary>
        /// <returns>El status del dispositivo.</returns>
        public string status;

        /// <summary>
        /// Enciende el lavarropas.
        /// </summary>
        public void On() 
        {
            this.status = "on";
            Console.WriteLine("The WashingMachine is on");
        }

         /// <summary>
        /// Apaga el lasvarropas.
        /// </summary>
        public void Off() 
        {
            this.status = "off";
            Console.WriteLine("The WashingMachine is off");
        }    

        /// <summary>
        /// Retorna el status del lavarropas.
        /// </summary>
        public string GetStatus() 
        {
            return this.status;
        }   
    }
}