using System;
using System.Collections.Generic;

namespace Taller1
{
    class Lista

    {//Se crea las listas de libros, usuarios y comentarios
        List<Usuario> usuarios = new List<Usuario>();
        List<libros> libros = new List<libros>();
        List<Comentarios> comentarios = new List<Comentarios>();

        Boolean op = true;

        int id = 1;
        string nombre, telefono,email;

        public void imprimir()
        {
            for (int i = 0; i < libros.Count; i++)//Recorremos los libros
            {
                Console.WriteLine("\n----------------Publicaciones Existentes----------------");
                Console.WriteLine("Fecha de publicacion: " + libros[i].Fecha_de_publicacion);
                Console.WriteLine("Nombre del libro: " + libros[i].Nombre);
                Console.WriteLine("Por: " + libros[i].Autor);
                Console.WriteLine("         " + libros[i].addCo);


                for (int x = 0; x < comentarios.Count; x++)//Recorremos los comentarios 
                {
                    if (comentarios[x].Num_Publicacion == i + 1)
                    {
                        Console.WriteLine("Fecha: " + comentarios[x].Fecha_de_publicacion);
                        Console.WriteLine("         " + comentarios[x].Comments);
                        Console.WriteLine("Comentarios hechos por: " + comentarios[x].visitante);
                        Console.WriteLine("-------------Fin de comentaros-----------------");
                    }
                }
            }
        }

        public void Informacion()
        {
            Console.WriteLine("Favor ingrese su Nombre y telefono a continuacion:");
            id++;//Vamos aumentando el id de usuario automaticamente
            Console.WriteLine("Nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Telefono");
            telefono = Console.ReadLine();
            Console.WriteLine("Email");
            email = Console.ReadLine();


            usuarios.Add(new Usuario { id = id, Nombre = nombre, tel = telefono,email=email });
        }
    }
}