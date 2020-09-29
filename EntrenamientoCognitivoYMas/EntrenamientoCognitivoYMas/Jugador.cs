using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntrenamientoCognitivoYMas
{
    class Jugador
    {
        private string _strNick;
        private int _intAprendeEscribiendo;
        private int _intPalabrasFlash;
        private int _intEncuentraLaPalabra;

        //Propiedades
        public string Nick
        {
            get { return _strNick; }
            set { _strNick = value; }
        }
        public int AprendeEscribiendo
        {
            get { return _intAprendeEscribiendo; }
            set { _intAprendeEscribiendo = value; }
        }
        public int PalabrasFlash
        {
            get { return _intPalabrasFlash; }
            set { _intPalabrasFlash = value; }
        }
        public int EncuentraLaPalabra
        {
            get { return _intEncuentraLaPalabra; }
            set { _intEncuentraLaPalabra = value; }
        }
    }
}
