//-------------------------------------------------------------------------
// <copyright file="Song.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------
using System;

namespace AdapterExample
{
    /// <summary>
    /// Un enchufe inteligente
    /// </summary>
    public class Plug
    {
        /// <summary>
        /// Crea un nuevo enchufe inteligente.
        /// </summary>
        /// <param name="id">ID del dispositivo.</param>
        /// <returns>El enchufe recién creada.</returns>
        public Plug(string id)
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
        /// Cambia el estado
        /// </summary>
        public void ToggleStatus() 
        {
            if (this.status.Equals("off"))
            {
            this.status = "on";
            Console.WriteLine("The Plug is on");
            }
            else
            {
            this.status = "off";
            Console.WriteLine("The Plug is off");
            }
        }

        /// <summary>
        /// Retorna el status de l enchufe.
        /// </summary>
        public string GetStatus() 
        {
            return this.status;
        }   
    }
}