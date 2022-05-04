namespace SeriesLib 
{

   
    public class Serie
    {
        private string titulo;
        private int numeroDeTemporadas;
        public bool entregado;
        private string genero;
        private string creador;      
        

        public Serie(string genero = "Policial-Suspenso", int numeroDeTemporadas = 3)
        {

            this.numeroDeTemporadas = numeroDeTemporadas;
            this.genero = genero;

        }

        public Serie(string titulo = "Dexter", string creador = "Genndy Tartakovsky")
        {
            this.titulo = titulo;
            this.creador = creador;

        }

        public Serie(string titulo = "Dexter", string creador = "Genndy Tartakovsky", string genero = "Policial-Suspenso", int numeroDeTemporadas = 3)
        {
            this.titulo = titulo;
            this.creador = creador;
            this.genero = genero;
            this.numeroDeTemporadas = numeroDeTemporadas;
        }

        public Serie(String titulo, String genero, String creador, int numeroDeTemporadas, bool entregado)
        {
            this.titulo = titulo;
            this.genero = genero;
            this.creador = creador;
            this.numeroDeTemporadas = numeroDeTemporadas;
            this.entregado = entregado;

        }


        


        

        


        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public int NumeroDeTemporadas
        {
            get { return numeroDeTemporadas; }
            set { numeroDeTemporadas = value; }
        }       

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public string Creador
        {
            get { return creador; }
            set { creador = value; }
        }

    }
}

/*
public void InfoDeLaSerie()
{
    Console.WriteLine("Titulo: {0}", titulo);
    Console.WriteLine("N° de temporadas: {0}", numeroDeTemporadas);
    Console.WriteLine("¿Esta entregada?: {0}", entregado);
    Console.WriteLine("Genero: {0}", genero);
    Console.WriteLine("Creador: {0}", creador);

}
*/