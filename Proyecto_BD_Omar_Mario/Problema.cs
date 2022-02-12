using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_BD_Omar_Mario
{
    class Problema
    {
        private int ID;
        private String NOMBRE;
        private String DESCRIPCION;
        private int IDCAT;
        private decimal PUNTAJE;
        private String DIFICULTAD;
        private String GESTOR;
        private String BD;
        private String VISIBILIDAD;
        private String FECHA;
        private String FUENTE;
        private String SOLUCION;
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
        public int idcat
        {
            get
            {
                return IDCAT;
            }
            set
            {
                IDCAT = value;
            }
        }
        public decimal puntaje
        {
            get
            {
                return PUNTAJE;
            }
            set
            {
                PUNTAJE = value;
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
        public String gestor
        {
            get
            {
                return GESTOR;
            }
            set
            {
                GESTOR = value;
            }
        }
        public String bd
        {
            get
            {
                return BD;
            }
            set
            {
                BD = value;
            }
        }
        public String dificultad
        {
            get
            {
                return DIFICULTAD;
            }
            set
            {
                DIFICULTAD = value;
            }
        }
        public String visibilidad
        {
            get
            {
                return VISIBILIDAD;
            }
            set
            {
                VISIBILIDAD = value;
            }
        }
        public String fecha
        {
            get
            {
                return FECHA;
            }
            set
            {
                FECHA = value;
            }
        }
        public String fuente
        {
            get
            {
                return FUENTE;
            }
            set
            {
                FUENTE = value;
            }
        }
        public String solucion
        {
            get
            {
                return SOLUCION;
            }
            set
            {
                SOLUCION = value;
            }
        }
    }
}
