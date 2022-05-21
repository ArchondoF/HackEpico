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
        private string Imagen;
        private string Link;

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
        public string getImagen()
        {
            return this.Imagen;
        }
        public void setImagen(string _Imagen)
        {
            this.Imagen = _Imagen;
        }
        public string getLink()
        {
            return this.Link;
        }
        public void setLink(string _Link)
        {
            this.Link = _Link;
        }
    }
}
