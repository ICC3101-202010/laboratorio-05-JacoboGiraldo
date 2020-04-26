using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratorio05
{
    public class User
    {
        

        public void OnEmailSent(object source, EventArgs args)
        {
            Thread.Sleep(2000);
            Console.WriteLine("El correo del proceso de registro ha sido exitosamente enviado");
            Thread.Sleep(2000);
        }
    }
}
