namespace ArbolesGenerales
{
    internal class Arbol
    {
        public Nodo Raiz { get; }
        public Arbol(string raiz)
        {
            Raiz = new Nodo(raiz);
        }

        public Nodo Agregar(string valor, Nodo nodoPadre)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                throw new Exception("El valor esta vacio");
            }

            if (nodoPadre == null)
            {
                throw new Exception("El padre no puede ser nulo");
            }

            if (nodoPadre.Hijo == null)
            {
                nodoPadre.Hijo = new Nodo(valor);
                return nodoPadre.Hijo;
            }
            else
            {
                Nodo nodoActual = nodoPadre.Hijo;
                while (nodoActual.Hermano != null)
                {
                    nodoActual = nodoActual.Hermano;
                }
                nodoActual.Hermano = new Nodo(valor);
                return nodoActual.Hermano;
            }
        }
    }
}
