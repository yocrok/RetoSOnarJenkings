using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cargadatosuma
{
    public class dtoEstudiante
    {
        private int _idalumno;
        private string _strnombre;
        private string _apellido1;
        private string _apellido2;
        private string _dtfechanac;
        private string _codpais;
        private string _codprovincia;
        private string _codcanton;
        private string _coddistrito;
        private string _strdireccion;
        private string _strsexo;
        private string _strcorreo;
        private string _strtelefono;
        private string _strcondicion;


        public int idalumno
        {
            get { return _idalumno; }
            set { _idalumno = value; }
        }

        public string strnombre
        {
            get { return _strnombre; }
            set { _strnombre = value; }
        }

        public string apellido1
        {
            get { return _apellido1; }
            set { _apellido1 = value; }
        }

        public string apellido2
        {
            get { return _apellido2; }
            set { _apellido2 = value; }
        }

        public string dtfechanac
        {
            get { return _dtfechanac; }
            set { _dtfechanac = value; }
        }

        public string codpais
        {
            get { return _codpais; }
            set { _codpais = value; }
        }

        public string codprovincia
        {
            get { return _codprovincia; }
            set { _codprovincia = value; }
        }

        public string codcanton
        {
            get { return _codcanton; }
            set { _codcanton = value; }
        }

        public string coddistrito
        {
            get { return _coddistrito; }
            set { _coddistrito = value; }
        }

        public string strdireccion
        {
            get { return _strdireccion; }
            set { _strdireccion = value; }
        }

        public string strsexo
        {
            get { return _strsexo; }
            set { _strsexo = value; }
        }

        public string strcorreo
        {
            get { return _strcorreo; }
            set { _strcorreo = value; }
        }

        public string strtelefono
        {
            get { return _strtelefono; }
            set { _strtelefono = value; }
        }

        public string strcondicion
        {
            get { return _strtelefono; }
            set { _strtelefono = value; }
        }
    }
}
