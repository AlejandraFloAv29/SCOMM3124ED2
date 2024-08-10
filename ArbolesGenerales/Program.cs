namespace ArbolesGenerales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arbol arbol = new Arbol("A");
            //Console.WriteLine(arbol.Raiz.Valor);

            //Nodo nodoB = arbol.Agregar("B", arbol.Raiz);
            //Nodo nodoC = arbol.Agregar("C", arbol.Raiz);
            //Nodo nodoD = arbol.Agregar("D", nodoB);
            //Nodo nodoE = arbol.Agregar("E", nodoB);
            //Nodo nodoF = arbol.Agregar("F", nodoB);
            //int x = 0;
            ////Pepe(ref x);
            ////Console.WriteLine(x);

            ////int y = 0;
            ////y = Pancho(y);
            ////Console.WriteLine(y);

            Jacobo(out int z);
            Console.WriteLine(z);
        }

        static void Pepe(ref int x) 
        {
            x = 5;
        }

        static void Jacobo(out int x)
        {
            x = 5;
        }

        static int Pancho(int x)
        {
            x = 5;
            return x;
        }
    }
}
