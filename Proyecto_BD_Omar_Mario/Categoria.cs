using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_BD_Omar_Mario
{
    class Categoria
    {
        private int ID;
        private String NOMBRE;
        private String DESCRIPCION;

        public int id
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }
        public String nombre
        {
            get
            {
                return NOMBRE;
            }
            set
            {
                NOMBRE = value;
            }
        }
        public String descripcion
        {
            get
            {
                return DESCRIPCION;
            }
            set
            {
                DESCRIPCION = value;
            }
        }
    }
}
