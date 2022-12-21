//----------------------------------------------------------------------------------
// <copyright file="AdapterExample.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//----------------------------------------------------------------------------------
namespace AdapterExample
{
    /// <summary>
    /// Una interface para todos los dispositivos inteligentes
    /// </summary>

    public interface ISmartDevice
    {         

        /// <summary>
        /// Enciende el dispositivo.
        /// </summary>        
        void On();  
        
        /// <summary>
        /// Apaga el dispositivo.
        /// </summary>          
        void Off();

        /// <summary>
        /// Estado el dispositivo.
        /// </summary>  
        string GetStatus();
    }
}