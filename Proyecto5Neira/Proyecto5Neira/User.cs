using System;
namespace Proyecto5Neira
{
    public class User
    {
        // Paso 1: Creamos el delegate para el evento del registro
        public delegate void EmailVerifiedEventHandler(object source, EventArgs args);
        // Paso 2: Creamos el evento que se engatilla cuando el usuario se registra
        public event EmailVerifiedEventHandler EmailVerified;
        // Paso 3: Publicamos el evento. Notar que cuando se quiere engatillar el evento, se llama OnRegistered(). 
        // Por definicion, debe ser protected virtual. Los parametros que recibe son los necesarios para crear una instancia
        // de la clase  RegisterEventArgs
        protected virtual void OnEmailVerified()
        {
            // Verifica si hay alguien suscrito al evento
            if (EmailVerified != null)
            {
                // Engatilla el evento
                EmailVerified(this, EventArgs.Empty);
            }
        }
        public void OnEmailSent(object source, EventArgs e)
        {
            Console.WriteLine("Verificar email? ['si' o 'no']");
            string a = Console.ReadLine();
            if (a == "si")
            {
                OnEmailVerified();
            }
        }
    }
}
