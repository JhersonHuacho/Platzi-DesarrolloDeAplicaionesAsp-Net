using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria, ciudad: "Bogota", pais: "Colombia");
   
            escuela.Cursos = new List<Curso>()
            {
                new Curso() { Nombre = "101", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "201", Jornada = TiposJornada.Mañana },
                new Curso { Nombre = "301", Jornada = TiposJornada.Mañana }
            };     
            escuela.Cursos.Add(new Curso { Nombre = "102", Jornada = TiposJornada.Tarde });
            escuela.Cursos.Add(new Curso { Nombre = "202", Jornada = TiposJornada.Tarde });

            var otraColeccion = new List<Curso>()
            {
                new Curso() { Nombre = "401", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "501", Jornada = TiposJornada.Mañana },
                new Curso { Nombre = "502", Jornada = TiposJornada.Tarde }
            };     

            escuela.Cursos.AddRange(otraColeccion);
            ImprimirCursosEscuela(escuela);   
            
            // elimina forma 01
            Predicate<Curso> miAlgoritmo = Predicado;   
            escuela.Cursos.RemoveAll(miAlgoritmo);
            // elimina forma 02
            escuela.Cursos.RemoveAll(Predicado);
            // elimina forma 03
            escuela.Cursos.RemoveAll(delegate (Curso cur) {
                return cur.Nombre == "401";
            });
            // elimina forma 04 : usando expresiones lambda, que a las finales tambien es un delegado
            escuela.Cursos.RemoveAll( (cur) => cur.Nombre == "501");  

            ImprimirCursosEscuela(escuela);               

            /* 
            Curso tmp = new Curso(){ Nombre = "101-Vacacional", Jornada = TiposJornada.Noche };
            escuela.Cursos.Add(tmp);
            ImprimirCursosEscuela(escuela);         
            */

            //WriteLine("Curso.Hash " + tmp.GetHashCode());   
            //escuela.Cursos.Remove(tmp);
                                
            //otraColeccion.Clear();
            //ImprimirCursosEscuela(escuela);
        }

        private static bool Predicado(Curso cursoObj)
        {
            return cursoObj.Nombre == "301";
        }
        
        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("============================");
            WriteLine("Cursos de la Escuela");
            WriteLine("============================");

            if (escuela?.Cursos != null) // no voy a verificar Cursos salvo que la escuale sea diferente  denull               
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre : {curso.Nombre}, Id : {curso.UniqueId}");
                }
            }            
            WriteLine("============================");
        }

        private static void ImprimirCursoWhile(Curso[] arregloCurso)
        {
            int contador = 0;
            while (contador < arregloCurso.Length)
            {
                Console.WriteLine($"Nombre {arregloCurso[contador].Nombre}, Id {arregloCurso[contador].UniqueId}");
                contador++;
            }
        }
        private static void ImprimirCursoDoWhile(Curso[] arregloCurso)
        {
            int contador = 0;
            do
            {
                Console.WriteLine($"Nombre {arregloCurso[contador].Nombre}, Id {arregloCurso[contador].UniqueId}");
                contador++;
            } while (contador < arregloCurso.Length);
        }
        private static void ImprimirCursoFor(Curso[] arregloCurso)
        {
            for (int i = 0; i < arregloCurso.Length; i++)
            {
                Console.WriteLine($"Nombre {arregloCurso[i].Nombre}, Id {arregloCurso[i].UniqueId}");
            }
        }
        private static void ImprimirCursoForEach(Curso[] arregloCurso)
        {
            foreach (var curso in arregloCurso)
            {
                Console.WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}");
            }

        }
    }
}
