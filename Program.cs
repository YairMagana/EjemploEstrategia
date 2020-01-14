using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEstrategia
{

    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            string n = menu.PreguntarNombreImagen();

            IGeneradorGuaradores generadorGuaradores = new GeneradorGuaradores();

            IProcesadorImagen procesadorImagen = generadorGuaradores.crearInstancia(menu.GenerarMenuTiposImagen());

            procesadorImagen.GuardarImagen(n);

            Console.ReadKey();
        }
    }
}
