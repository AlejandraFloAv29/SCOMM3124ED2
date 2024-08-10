namespace ArbolesGenerales
{
    internal class Arbol
    {
        public Nodo Raiz { get; }

        public Arbol(string dato)
        {
            Raiz = new Nodo(dato);
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

        private void Recorrer(Nodo nodo, ref int posicion, ref string datos)
        {
            if (nodo != null)
            {
                string dato = nodo.Valor;
                int cantidadGuiones = dato.Length + posicion;
                string datoConGuiones = dato.PadLeft(cantidadGuiones, '-');
                datos += $"{datoConGuiones}{Environment.NewLine}";
                //Es lo mismo pero en una sola linea
                //datos += $"{nodo.Valor.PadLeft(nodo.Valor.Length + posicion, '-')}{Environment.NewLine}";

                if (nodo.Hijo != null)
                {
                    posicion++;
                    Recorrer(nodo.Hijo, ref posicion, ref datos);
                    posicion--;
                }

                if (nodo.Hermano != null && posicion != 0)
                {
                    Recorrer(nodo.Hermano, ref posicion, ref datos);
                }
            }
        }

        public string Obtener(Nodo nodo = null)
        {
            if (nodo == null)
            {
                nodo = Raiz;
            }

            int posicion = 0;
            string datos = string.Empty;
            Recorrer(nodo, ref posicion, ref datos);
            return datos;
        }
    }
}