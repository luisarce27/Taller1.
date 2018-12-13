using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();
            Publicacion publicacion = new Publicacion();


            int select = 0;
            Console.WriteLine("Tipo de usuario 1- Editor 2-Lector");
            while (select != 3)
            {
               
                string cadselec;

                cadselec = Console.ReadLine();

                select = Convert.ToInt32(cadselec);

                if (select == 1)
                {
                    Console.WriteLine("Presione 3 para salir");
                    Console.WriteLine("Usuario seleccionado es usuario ");

                   

                }else if(select == 2){

                    Console.WriteLine("Usuario tipo Lector puede agregar un comentario a la publicacion");
                }

            }

            


        }
    }
}
