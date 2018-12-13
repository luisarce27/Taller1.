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
            Lista lista = new Lista();
            lista.imprimir();//Se imprime 
            lista.Informacion();//Mostrar la Informacion

            Opciones k = new Opciones();
            k.Options();//Muestra el menu de opciones
            
        }

    }
}