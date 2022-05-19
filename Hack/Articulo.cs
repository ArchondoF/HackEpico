using System;
using System.Collections.Generic;
using System.Text;

namespace Hack
{
    public class Articulo
    {
        private string Titulo;
        private string Precio;
        private string Ubicacion = "No disponible";

        public Articulo()
        {

        }

        public string getTitulo()
        {
            return this.Titulo;
        }
        public void setTitulo(string _Titulo)
        {
            this.Titulo = _Titulo;
        }
        public string getUbicacion()
        {
            return this.Ubicacion;
        }
        public void setUbicacion(string _Ubicacion)
        {
            this.Ubicacion = _Ubicacion;
        }
        public string getPrecio()
        {
            return this.Precio;
        }
        public void setPrecio(string _Precio)
        {
            this.Precio = _Precio;
        }
    }
}
