using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1
{
    class Publicacion
    {

        public DateTime FechaPublicacion { get; set; }
        public string Autor { get; set; }
        public string Contenido { get; set; }
        public int NumeroPublicacion { get; set; }
        public List<Comentario> Comentarios {get;set; }
        
        public void AgregarPublicacion()
        {

            Publicacion D = new Publicacion();

        }

    }
}
