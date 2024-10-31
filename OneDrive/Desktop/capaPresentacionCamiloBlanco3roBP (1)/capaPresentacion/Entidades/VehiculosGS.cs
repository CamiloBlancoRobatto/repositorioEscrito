using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculosGS
    {
        private string matricula;
        private string marca;
        private string modelo;
        private int anio;
        private int cod_serv;


     
        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public int Anio
        {
            get { return anio; }
            set { anio = value; }
        }
        public int Cod_serv
        {
            get { return cod_serv; }
            set { cod_serv = value; }
        }
    }
}
