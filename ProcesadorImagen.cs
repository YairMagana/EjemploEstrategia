using System;

namespace EjemploEstrategia
{
    public class ProcesadorImagen : IProcesadorImagen
    {
        private IGuardadorImagenes guardadorImagenes;

        public ProcesadorImagen(IGuardadorImagenes guardadorImagenes)
        {
            this.guardadorImagenes = guardadorImagenes;
        }

        public void GuardarImagen(string nombre)
        {
            Console.WriteLine($"Imagen: {nombre} {guardadorImagenes.GuardarImagen()}");
        }
    }
}
