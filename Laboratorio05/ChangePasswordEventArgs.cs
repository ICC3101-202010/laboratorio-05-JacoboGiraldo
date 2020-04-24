using System;
namespace Laboratorio05
{
    public class ChangePasswordEventArgs
    {
        public string Email { get; set; }
        public string Number { get; set; }
        public string Username { get; set; }
    }
}
