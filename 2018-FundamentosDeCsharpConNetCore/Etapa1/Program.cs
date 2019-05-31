using System;
using CoreEscuela.Entidades;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2012);
            escuela.Pais = "Colombia";
            escuela.Ciudad = "Bogota";
            escuela.TipoEscuela = TiposEscuela.Inicial;            
            escuela.Cursos = new Curso[]
            {
                new Curso() { Nombre = "101" },
                new Curso() { Nombre = "201" },
                new Curso { Nombre = "301" }
            };

            ImprimirCursosEscuela(escuela);
            
            var arregloCursoUno = new Curso[3];
            arregloCursoUno[0] = new Curso()
            {
                Nombre = "101"
            };

            var curso2 = new Curso()
            {
                Nombre = "201"
            };
            arregloCursoUno[1] = curso2;

            arregloCursoUno[2] = new Curso
            {
                Nombre = "301"
            };

            var arregloCursoDos = new Curso[3] 
            {
                new Curso() { Nombre = "101" },
                new Curso() { Nombre = "201" },
                new Curso { Nombre = "301" }
            };
            var arregloCursoTres = new Curso[] 
            {
                new Curso() { Nombre = "101" },
                new Curso() { Nombre = "201" },
                new Curso { Nombre = "301" }
            };
            Curso[] arregloCursoCuatro =  
            {
                new Curso() { Nombre = "101" },
                new Curso() { Nombre = "201" },
                new Curso { Nombre = "301" }
            };            

            Console.WriteLine(escuela);
            System.Console.WriteLine("===== While ======");
            ImprimirCursoWhile(arregloCursoUno);
            System.Console.WriteLine("===== Do While ===");
            ImprimirCursoDoWhile(arregloCursoUno);
            System.Console.WriteLine("===== For ========");
            ImprimirCursoFor(arregloCursoUno);
            System.Console.WriteLine("===== Foreach ====");
            ImprimirCursoForEach(arregloCursoUno);            

            var escuela2 = new Escuela("Platzi Academy 2", 2012, TiposEscuela.Inicial, ciudad: "Bogota");
            Console.WriteLine(escuela2);
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
