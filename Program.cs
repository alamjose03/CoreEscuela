using System;
using CoreEscuela.Entidades;
using System.Collections.Generic;
using CoreEscuela;
using CoreEscuela.Util;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.DrawLine();
            ImprimirCursosEscuela(engine.Escuela);
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.WriteTitle("Cursos Escuela");

            if (escuela?.curso != null)
            {
                foreach (var curso in escuela.curso)
                {
                    Console.WriteLine($"Nombre {curso.Nombre}, Id  {curso.UniqueId}");

                }

            }
        }

    }
}