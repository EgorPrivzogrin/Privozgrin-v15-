namespace ClassLibrary1
{
    public class Pantalla
    {
        public string Laberinto;
        public Elementos Elementos { get; set; }
        public Player Player { get; set; }
        public Pantalla(Elementos elementos,Player player) 
        { 
            Elementos = elementos;
            Player= player;
        }
    }
}