namespace ArbolesGenerales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arbol arbol = new Arbol("A");
            Console.WriteLine(arbol.Raiz.Valor);

            Nodo nodoB = arbol.Agregar("B", arbol.Raiz);
            Nodo nodoC = arbol.Agregar("C", arbol.Raiz);
            Nodo nodoD = arbol.Agregar("D", nodoB);
            Nodo nodoE = arbol.Agregar("E", nodoB);
            Nodo nodoF = arbol.Agregar("F", nodoB);
            Nodo nodoG = arbol.Agregar("G", nodoC);
            Nodo nodoH = arbol.Agregar("H", nodoC);
            Console.WriteLine(arbol.Obtener());
        }

    }
}
