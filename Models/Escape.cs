public static class Escape{
    private static string[] incognitasCorrectas={"Agua","1", "2","B","3"};
    private static int EstadoJuego = 1;

    private static void InicializarJuego(){
        EstadoJuego = 1;
    }
    public static int GetEstadoJuego(){
        return EstadoJuego;
    }
    public static bool ResolverSala(int Sala, string IncognitaElegida){
        bool noPerdi=false;
        if (EstadoJuego==Sala && IncognitaElegida==incognitasCorrectas[EstadoJuego-1])
        {
            noPerdi=true;
            EstadoJuego++;
        }
        return noPerdi;
    }
}