string[] SeriesTitulo = { "Dexter", "Invencible", "The big bang theory" };
string[] SeriesGenero = { "Policial", "Superheroes", "Comedia" };
string[] SeriesCreador = { "Genndy Tartakovsky", "Robert Kirkman", "Chuck Lorre" };
int[] SeriesNumeroDeTemporadas = { 3, 5, 10 };
bool[] SeriesEntregado = { false, true };
string[] GamesTitulo = { "God of war", "Horizon zero dawn", "Nier automata" };
string[] GamesGenero = { "Mitologia", "Ciencia Ficcion" };
string[] GamesCompañia = { "Santa Monica", "Guerilla Games", "Yoko Taro" };
int[] GamesHoras = { 3, 10, 40 };
bool[] GamesEntregado = { false, true };
string[] GamesPrestado = { };

Serie Dexter = new Serie(SeriesTitulo[0], SeriesGenero[0], SeriesCreador[0], SeriesNumeroDeTemporadas[0]);
Serie Invencible = new Serie(SeriesTitulo[1], SeriesGenero[1], SeriesCreador[1], SeriesNumeroDeTemporadas[1], SeriesEntregado[1]);
Serie TheBigBangTheory = new Serie(SeriesTitulo[2], SeriesGenero[2], SeriesCreador[2], SeriesNumeroDeTemporadas[2]);


Console.WriteLine(@$"Serie 1:
    Titulo: {Dexter.Titulo}
    Temporadas: {Dexter.NumeroDeTemporadas}
    Emtregado?: {Dexter.entregado}
    Genero: {Dexter.Genero}
    Creador: {Dexter.Creador}");
Console.WriteLine();
Console.WriteLine(@$"Serie 2:
    Titulo: {Invencible.Titulo}
    Temporadas: {Invencible.NumeroDeTemporadas}
    Entregado?: {Invencible.entregado}
    Genero: {Invencible.Genero}
    Creador: {Invencible.Creador}");
Console.WriteLine();
Console.WriteLine(@$"Serie 3:
    Titulo: {TheBigBangTheory.Titulo}
    Temporadas: {TheBigBangTheory.NumeroDeTemporadas}
    Entregado?: {TheBigBangTheory.entregado}
    Genero: {TheBigBangTheory.Genero}
    Creador: {TheBigBangTheory.Creador}");



Console.WriteLine();

Videogames GodOfWar = new Videogames(GamesTitulo[0], GamesGenero[0], GamesCompañia[0], GamesHoras[0] );
Videogames HorizonZeroDawn = new Videogames(GamesTitulo[1], GamesGenero[1], GamesCompañia[1], GamesHoras[1]);
Videogames NierAutomata = new Videogames(GamesTitulo[2], GamesGenero[1], GamesCompañia[2], GamesHoras[2], GamesEntregado[1]);
Console.WriteLine(@$"Video Juego 1:
    Titulo: {GodOfWar.Titulo}
    Horas Estimadas: {GodOfWar.HorasEstimadas}
    Entregado?: {GodOfWar.entregado}
    Genero: {GodOfWar.Genero}
    Compañia: {GodOfWar.Compañia}");
Console.WriteLine();
Console.WriteLine(@$"Video Juego 2:
    Titulo: {HorizonZeroDawn.Titulo}
    Horas Estimadas: {HorizonZeroDawn.HorasEstimadas}
    Entregado?: {HorizonZeroDawn.entregado}
    Genero: {HorizonZeroDawn.Genero}
    Compañia: {HorizonZeroDawn.Compañia}");
Console.WriteLine();
Console.WriteLine(@$"Video Juego 3:
    Titulo: {NierAutomata.Titulo}
    Horas Estimadas: {NierAutomata.HorasEstimadas}
    Entregado?: {NierAutomata.entregado}
    Genero: {NierAutomata.Genero}
    Compañia: {NierAutomata.Compañia}");




/*Console.WriteLine("Videogame 1:");
GodOfWar.InfoDeLosJuegos();
Console.WriteLine();
Console.WriteLine("Videogame 2:");
HorizonZeroDawn.InfoDeLosJuegos();
Console.WriteLine();
Console.WriteLine("Videogame 3:");
NierAutomata.InfoDeLosJuegos();*/
