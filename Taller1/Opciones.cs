using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1
{
    internal class Opciones : Lista
    {
        List<Usuario> usuarios = new List<Usuario>();
        List<libros> libros = new List<libros>();
        List<Comentarios> comentarios = new List<Comentarios>();
        Boolean opciones = true;

        int id = 1, numPublicacion = 1, numComentario = 1;
        string nombre, tel, email;
        public void Options()
        {
            while (opciones)
            {
                Informacion();

                Console.WriteLine(

                    "\nSeleccione 1.Editar \n2.Comentar " +
                    "\n3.Salir");
                string Select = Console.ReadLine();

                if (Select.Equals("1"))
                {
                    Boolean op = true;
                    while (op)
                    {
                        Console.WriteLine(
                            "\n¿Que desea editar? : " +
                            "\n 1.Nuueva publicación " +
                            "\n 2.Lista de publicaciones " +
                            "\n 3.Presione para Salir");
                        string opcion = Console.ReadLine();
                        if (opcion.Equals("1"))
                        {
                            Console.WriteLine("\nContenido a agregar");
                            string addContent = Console.ReadLine();

                            libros.Add(new libros { id = numPublicacion, Autor = nombre, Fecha_de_publicacion = DateTime.Now, addCo = addContent });
                            Console.WriteLine("Numero de  libro " + numPublicacion + " Se agrego correctamente\n");
                            numPublicacion++;
                        }
                        else
                        {
                            if (opcion.Equals("2"))
                            {
                                Console.WriteLine("\n Lista de publicaciones es: ");
                                imprimir();
                            }
                            else
                            {
                                Console.ReadLine();
                                op = false;
                            }
                        }
                    }
                }
                else
                {
                    if (Select.Equals("2"))
                    {
                        Boolean op2 = true;
                        while (op2)
                        {
                            Console.WriteLine(
                                "\nSeleccione: " +
                                "\n1.Ingresar un nuevo comentario " +
                                "\n2.Mostrar la lista de publicaciones " +
                                "\n3. Para Salir");
                            string opcion = Console.ReadLine();
                            if (opcion.Equals("1"))
                            {

                                Console.WriteLine("\nIngrese Id del libro:");
                                id = Convert.ToInt32(Console.ReadLine());
                                Boolean exis = true;

                                for (int i = 0; i < libros.Count; i++)
                                {
                                    if (libros[i].id == id)
                                    {
                                        Console.WriteLine("\nIngrese comentario");
                                        string Comments = Console.ReadLine();
                                        comentarios.Add(new Comentarios { id = numComentario, visitante = nombre, Num_Publicacion = id, Fecha_de_publicacion = DateTime.Now, Comments = Comments });
                                        Console.WriteLine("Comentario " + numComentario + "se agrego correctamente a la publicacion: " + libros[i].id + "\n");
                                        numComentario++;
                                        exis = false;
                                    }
                                }


                                if (exis)
                                {
                                    Console.WriteLine("\nNo esta la publicacion" +
                                        "");
                                    Console.ReadLine();
                                }
                            }
                            else
                            {
                                if (opcion.Equals("2"))
                                {
                                    imprimir();
                                }
                                else
                                {
                                   
                                    Console.ReadLine();
                                    op2 = false;
                                }
                            }
                        }
                    }
                    else
                    {
                        opciones = false;
                        Console.WriteLine("Cerrando....");
                        Console.ReadLine();
                    }

                }

            }
        }


    }
}
