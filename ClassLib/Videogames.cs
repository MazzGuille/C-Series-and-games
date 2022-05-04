namespace GamesLib
{
         public class Videogames
        {
           
            private string titulo;
            private int horasEstimadas;
            public bool entregado = false;
            private string genero;
            private string compañia;

            public Videogames (string genero = "Policial-Suspenso", int horasEstimadas = 3)
            {
                this.horasEstimadas = horasEstimadas;
                this.genero = genero;
            }
            public Videogames(string titulo = "God of War", string compañia = "Monica Studios")
            {
                this.titulo = titulo;
                this.compañia = compañia;
                
            }

            public Videogames (string titulo = "God of War", string compañia = "Monica Studios", string genero = "Policial-Suspenso", int horasEstimadas = 3)
            {
                this.titulo = titulo;
                this.compañia = compañia;
                this.genero = genero;
                this.horasEstimadas = horasEstimadas;
                
            }

            public Videogames (string titulo, string compañia, string genero, int horasEstimadas, bool entregado)
            {
                this.titulo = titulo;
                this.compañia = compañia;
                this.genero = genero;
                this.horasEstimadas = horasEstimadas;
                this.entregado = entregado;
                
            }
            

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        
        public int HorasEstimadas
        {
            get { return horasEstimadas; }
            set { horasEstimadas = value; }
        }
           
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public string Compañia
        {
            get { return compañia; }
            set { compañia = value;}

        }
        }
}

/* public void InfoDeLosJuegos()
            {
                Console.WriteLine("Titulo: {0}", titulo);
                Console.WriteLine("Horas estimadas: {0}", horasEstimadas);
                Console.WriteLine("¿Esta entregada?: {0}", entregado);
                Console.WriteLine("Genero: {0}", genero);
                Console.WriteLine("Compañia: {0}", compañia);
            }*/