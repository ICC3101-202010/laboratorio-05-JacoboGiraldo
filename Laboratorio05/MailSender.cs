using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratorio05
{
    public class MailSender
    {
        public void OnRegistered(object source, RegisterEventArgs e)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"\nCorreo enviado a {e.Email}: \n Gracias por registrarte, {e.Username}!\n Por favor, para poder verificar tu correo, has click en: {e.VerificationLink}\n");
            Thread.Sleep(2000);
        }

        public void OnPasswordChanged(object source, ChangePasswordEventArgs e)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"\nCorreo enviado a {e.Email}:  \n {e.Username}, te notificamos que la contrasena de tu cuenta PlusCorp ha sido cambiada. \n");
            Thread.Sleep(2000);
        }
        public delegate void EmailSentEventHandler(object source, EventArgs args);
        public event EmailSentEventHandler EmailSent;
        protected virtual void OnEmailSent()
        {
            if (EmailSent != null)
            {
                // Engatilla el evento
                EmailSent(this, EventArgs.Empty);
            }
        }
       

        public void ESent(DataBase data)
        {
            if (data.IsData() == true)
            {
                //Dispara el evento
                OnEmailSent();
            }
            else if (data.IsData()== false)
            {
                //No dispara el evento
                Console.WriteLine("Hubo un error, su correo no ha podido ser enviado");
            }
                

        }

    }
}
