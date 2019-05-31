using System;
using System.Collections.Generic;
using CoreEscuela.App;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
           var engine = new EscuelaEngine();
           engine.Inicializar();
            Printer.Beep();              
           ImprimirCursosEscuela(engine.Escuela);               
        }        
        private static void ImprimirCursosEscuela(Escuela escuela)
        {            
            Printer.EscribirTitulo("Cursos de la Escuela");            

            if (escuela?.Cursos != null) // no voy a verificar Cursos salvo que la escuale sea diferente  denull               
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre : {curso.Nombre}, Id : {curso.UniqueId}");
                }
            }            
            WriteLine("============================");
        }        
    }
}
