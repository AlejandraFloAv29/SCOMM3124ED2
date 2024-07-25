namespace ArbolesGenerales
{
    internal class Nodo(string valor = "", Nodo? hermano = null, Nodo? hijo = null)
    {
        public string Valor { get; set; } = valor;
        public Nodo? Hermano { get; set; } = hermano;
        public Nodo? Hijo { get; set; } = hijo;
    }
}
