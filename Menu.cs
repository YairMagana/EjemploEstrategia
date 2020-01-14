using System;

namespace EjemploEstrategia
{
    public class Menu
    {
        public int GenerarMenuTiposImagen()
        {
            Console.WriteLine("\nGuardar como:\n  1. BMP\n  2. JPG\n  3. GIF");
            string sOp = Console.ReadLine();
            int nOP;
            int.TryParse(sOp, out nOP);

            return nOP;
        }

        public string PreguntarNombreImagen()
        {
            Menu menu = new Menu();
            Console.WriteLine("Nombre de Imagen:");
            return Console.ReadLine();
        }
    }
}
