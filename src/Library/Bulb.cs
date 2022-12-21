//-------------------------------------------------------------------------
// <copyright file="Song.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------
using System;

namespace AdapterExample
{
    /// <summary>
    /// Una lámpara inteligente
    /// </summary>
    public class Bulb: ISmartDevice
    {
        /// <summary>
        /// Crea una nueva lámpara inteligente.
        /// </summary>
        /// <param name="id">ID del dispositivo.</param>
        /// <returns>La lámpara recién creada.</returns>
        public Bulb(string id)
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
        /// Enciende la lámpara.
        /// </summary>
        public void On() 
        {
            this.status = "on";
            Console.WriteLine("The Bulb is on");
        }

         /// <summary>
        /// Apaga la lámpara.
        /// </summary>
        public void Off() 
        {
            this.status = "off";
            Console.WriteLine("The Bulb is off");
        }    

        /// <summary>
        /// Retorna el status de la lámpara.
        /// </summary>
        public string GetStatus() 
        {
            return this.status;
        }   
    }
}