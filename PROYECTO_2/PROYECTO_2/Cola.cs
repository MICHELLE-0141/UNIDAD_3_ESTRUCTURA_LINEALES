using System;
using System.Collections.Generic;
using System.Text;

namespace PROYECTO_2
{
    public class Cola
    {
        private Nodo frente;
        private Nodo final;

        public void Encolar(Cliente cliente)
        {
            Nodo nuevo = new Nodo(cliente);

            if (frente == null)

            {
                frente = nuevo;
                final = nuevo;
            }

            else
            {
                final.Siguiente = nuevo;
                final = nuevo;
            }
        }
    }
}
