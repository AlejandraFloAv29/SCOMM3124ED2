namespace ArbolesGenerales
{
    internal class Nodo
    {
        public string Valor { get; set; } = string.Empty;
        public Nodo? Hermano { get; set; } = null;
        public Nodo? Hijo { get; set; } = null;
    }
}
