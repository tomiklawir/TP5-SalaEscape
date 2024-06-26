class Escape
{
    private static string[] incognitasSalas = new string[2];
    private static int estadoJuego;

    public Escape(){
        incognitasSalas = {"2586", "MAGNATE"};
        estadoJuego = 1;
    }

    private static void InicializarJuego(){

    }

    public static int GetEstadoJuego(){
        return estadoJuego;
    }

    public static bool ResolverSala(int Sala, string Incognita){
        return false;
    }
}