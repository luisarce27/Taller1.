using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1
{
    class Comentario
    {
        public DateTime FechaComenterio { get; set; }
        public string Autor { get; set; }
        public string Contenido { get; set; }
        public int NumeroComentario { get; set; }
        private Publicacion Comentarios { get; set; }


        public void AgregarComentario()
        {
            Comentarios = new List<Publicacion>
            {
                new Publicacion(){Autor= "Jose", Comentarios= , Contenido="sdfhrjhferf",FechaPublicacion=15/1/2018,NumeroPublicacion=15/1/2018}

            };

        }
    }
}
