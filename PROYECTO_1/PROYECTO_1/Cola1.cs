using PROYECTO_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_1
{
    public class Cola1
    {
        private Nodo frente;
        private Nodo final;
        public Cola1()
        {
            frente = null;
            final = null;
        }
        public void Encolar(Paciente paciente)
        {
            Nodo nuevo = new Nodo(paciente);
            if (frente == null)
            {
                frente = nuevo;
                final = nuevo;
            }
        }
        public Paciente Desencolar()
        {
            if (frente == null)
                return null;
            Paciente paciente = frente.Datos;
            frente = frente.Siguiente;
            if (frente == null)
                final = null;
            return paciente;
        }
        public void Mostrar()
        {
            if (frente == null)
            {
                Console.WriteLine("No hay pacientes registrados.");
                return;
            }
            Nodo aux = frente;
            while (aux != null)
            {
                Console.WriteLine(aux.Datos);
                aux = aux.Siguiente;
            }
        }
    }
}