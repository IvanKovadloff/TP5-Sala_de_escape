public static class Escape{
    private static string[] incognitasCorrectas={"agua","1", "2","b","3","hallazgo", "17", "5"};
    private static int EstadoJuego = 1;

    public static void InicializarJuego(){
        EstadoJuego = 1;
    }
    public static int GetEstadoJuego(){
        return EstadoJuego;
    }
    public static bool ResolverSala(int Sala, string IncognitaElegida){
        bool noPerdi=false;
        if (EstadoJuego==Sala && IncognitaElegida.ToLower()==incognitasCorrectas[EstadoJuego-1])
        {
            noPerdi=true;
            EstadoJuego++;
        }
        return noPerdi;
    }
}