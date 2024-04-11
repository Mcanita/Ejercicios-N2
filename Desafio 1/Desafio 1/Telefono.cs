﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    class Telefono
    {
        //ATRIBUTOS
        private string modelo;
        private string marca;
        private string numeroTelefonico;
        private int codigoOperador;

        //CONSTRUCTOR
        public Telefono(string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;

        }

        //PROPIEDADES
        public string Modelo
        {
            get{ return modelo; }
        }

        public string Marca
        {
            get{ return marca; }
        }
        public string NumeroTelefonico
        {
            get { return numeroTelefonico; }
            set { numeroTelefonico = value; }
        }

        public int CodigoOperador
        {
            get { return codigoOperador ; }
            set
            { 
                if( value > 0 && value < 4)
                {
                    codigoOperador = value;
                }
                else
                    codigoOperador = -1;
            }
        }

        //METODOS

        public string Llamar()
        {
            return "Realizando llamada...";
        }

        public string Llamar(string contacto)
        {
            return "Llamando a " + contacto;
        }










    }
}
