using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto2
{
    public class Usuario
    {
        private string nombre;
        private string contrasenia;
        private string rol;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Contrasenia
        {
            get
            {
                return contrasenia;
            }

            set
            {
                contrasenia = value;
            }
        }

        public string Rol
        {
            get
            {
                return rol;
            }

            set
            {
                rol = value;
            }
        }

    }
}