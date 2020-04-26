using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratorio05
{
    public class User
    {

        // Atributo BaseDatos
        public DataBase data { get; }

        public void OnEmailSent(object source, EventArgs args)
        {
            Thread.Sleep(2000);
            Console.WriteLine("El correo del proceso de registro ha sido exitosamente enviado");
            Thread.Sleep(2000);
        }
        public delegate void EmailVerifiedEventHandler(object source, EventArgs args);
        public event EmailVerifiedEventHandler EmailVerified;
        protected virtual void OnEmailVerified()
        {
            if (EmailVerified != null)
            {
                // Engatilla el evento
                EmailVerified(this, EventArgs.Empty);
            }
        }
        public void VerificacionCorreo(DataBase data)
        {
            Console.WriteLine("Ingresa tu nombre de usuario: ");
            string usr = Console.ReadLine();
            if (data.GetData(usr) != null)
            {
                Console.WriteLine("Desea verificar su correo electronico? (Si/No)");
                string str = Console.ReadLine();
                if (str == "Si")
                {
                    Console.WriteLine("Su correo:");
                    Console.WriteLine(data.GetData(usr)[1]);
                    OnEmailVerified();
                }
            }
            else if (data.GetData(usr)==null)
            {
                Console.WriteLine("El nombre de usuario ingresado no es valido");
            }
        }
    }
}

