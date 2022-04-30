Serie Dexter = new Serie("Dexter", "Genndy Tartakovsky", "Policial-Suspenso", 3);
Serie Invencible = new Serie("Invencible", "Superheroes", "Robert Kirkman", 10, true);
Serie TheBigBangTheory = new Serie("The big bang Theory", "Comedia", "Chuck Lorre", 5);


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

Videogames GodOfWar = new Videogames("God of War", "Monica Studios", "Mitologia", 3);
Videogames HorizonZeroDawn = new Videogames("Horizon Zero Dawn", "Ciencia ficcion", "Guerilla Games");
Videogames NierAutomata = new Videogames("Nier Automata", "Ciencia ficcion", "Yoko Taro", 40, true);
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
