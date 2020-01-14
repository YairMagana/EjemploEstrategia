namespace EjemploEstrategia
{
    public class GeneradorGuaradores : IGeneradorGuaradores
    {
        public ProcesadorImagen crearInstancia(int n)
        {
            switch (n)
            {
                case 1:
                    return new ProcesadorImagen(new GuaradadorBMP());
                case 2:
                    return new ProcesadorImagen(new GuaradadorJPG());
                default:
                    return new ProcesadorImagen(new GuaradadorGIF());
            }
        }
    }
}
