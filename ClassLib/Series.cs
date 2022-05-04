namespace SeriesLib 
{

   
    public class Serie : IEntregable
    {
        

        private string _titulo;
        private int _numeroDeTemporadas;
        public bool Entregado = false;
        private string _genero;
        private string _creador;      
        

        public Serie(string genero = "Policial-Suspenso", int numeroDeTemporadas = 3)
        {

            this._numeroDeTemporadas = numeroDeTemporadas;
            this._genero = genero;

        }

        public Serie(string titulo = "Dexter", string creador = "Genndy Tartakovsky")
        {
            this._titulo = titulo;
            this._creador = creador;

        }

        public Serie(string titulo = "Dexter", string creador = "Genndy Tartakovsky", string genero = "Policial-Suspenso", int numeroDeTemporadas = 3)
        {
            this._titulo = titulo;
            this._creador = creador;
            this._genero = genero;
            this._numeroDeTemporadas = numeroDeTemporadas;
        }

        public Serie(String titulo, String genero, String creador, int numeroDeTemporadas, bool entregado)
        {
            this._titulo = titulo;
            this._genero = genero;
            this._creador = creador;
            this._numeroDeTemporadas = numeroDeTemporadas;
            this.Entregado = entregado;

        }

            //Metodos interfaz

        public void Prestado()
        {
            this.Entregado = false;
        }
       
        public void Entregar()
        {
            this.Entregado = true;
        }

        public void Devolver()
        {
            this.Entregado = false;
        }
        

        public bool IsEntregado()
        {
            return this.Entregado;
        }

        


        public string Titulo
        {
            get { return Titulo; }
            set { Titulo = value; }
        }

        public int NumeroDeTemporadas
        {
            get { return NumeroDeTemporadas; }
            set { NumeroDeTemporadas = value; }
        }       

        public string Genero
        {
            get { return Genero; }
            set { Genero = value; }
        }

        public string Creador
        {
            get { return Creador; }
            set { Creador = value; }
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