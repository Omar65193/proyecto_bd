using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto2
{
    public class Libro
    {
        private int ID;
        private long ISBN;
        private int EDICION;
        private int ANIO;
        private String AUTORES;
        private String PAIS;
        private String SINOPSIS;
        private String CARRERA;
        private String MATERIA;

        public int id{
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }

        public long isbn
        {
            get
            {
                return ISBN;
            }
            set
            {
                ISBN = value;
            }
        }
        public int edicion
        {
            get
            {
                return EDICION;
            }
            set
            {
                EDICION = value;
            }
        }
        public int anio
        {
            get
            {
                return ANIO;
            }
            set
            {
                ANIO = value;
            }
        }
        public String autores
        {
            get
            {
                return AUTORES;
            }
            set
            {
                AUTORES = value;
            }
        }
        public String pais
        {
            get
            {
                return PAIS;
            }
            set
            {
                PAIS = value;
            }
        }
        public String sinopsis
        {
            get
            {
                return SINOPSIS;
            }
            set
            {
                SINOPSIS = value;
            }
        }
        public String carrera
        {
            get
            {
                return CARRERA;
            }
            set
            {
                CARRERA = value;
            }
        }
        public String materia
        {
            get
            {
                return MATERIA;
            }
            set
            {
                MATERIA = value;
            }
        }
    }
}