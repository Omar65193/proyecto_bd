using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_BD_Omar_Mario
{
    class C_usuarios
    {
        private String USUARIO;
        
        public String usuario
        {
            get
            {
                return USUARIO;
            }
            set
            {
                USUARIO = value;
            }
        }

        private String CONTRASENIA;

        public String contrasenia
        {
            get
            {
                return CONTRASENIA;
            }
            set
            {
                CONTRASENIA = value;
            }
        }

        private int PERMISOS;

        public int permisos
        {
            get
            {
                return PERMISOS;
            }
            set
            {
                PERMISOS = value;
            }
        }

    }
}
