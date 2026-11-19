using System;
using System.Collections.Generic;
using System.Text;

namespace PROYECTO_1
{
    internal class Menu
    {
        static Cola1 paciente = new Cola1();

        static void Main(string[] args)
        {
            int Opcion;
            do
            {
                Console.Clear();

                Console.WriteLine("===CLINICA====");
                Console.WriteLine("1.Registar paciente"):
                Console.WriteLine("2.Antender paciente");
                Console.WriteLine("3.Mostrar pacientes");
                Console.WriteLine("0.Salir");
                Console.WriteLine("Opcion");

                Opcion = int.Parse(Console.ReadLine());

                switch (Opcion)
                {
                    case 1:
                        Registrar();
                        break;

                    case 2:
                        Atender();
                        break;

                    case 3:
                        paciente.Mostrar();
                        Console.ReadKey();
                        break;

                }


            } while (Opcion != 0);
        }

        static void Registrar()
        {
            Console.Write("Expediente:");
            int expediente = int.Parse(Console.ReadLine());

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("Prioridad: ");
            int prioridad = int.Parse(Console.ReadLine());

            Paciente paciente =
                new Paciente(expediente, nombre, edad, prioridad);

            paciente.Encolar();

            Console.WriteLine("Paciente registrado.");
            Console.ReadKey();

        }

        static void Atender()
        {
            Paciente paciente = paciente.Desencolar();

            if (paciente == null)
                Console.WriteLine("No hay paciente.");
            else
                Console.WriteLine("Atendiendo:");

            if (paciente != null)
                Console.WriteLine(paciente);
            Console.ReadKey();

        }
    }
}