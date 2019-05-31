using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;

namespace CoreEscuela.App
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {
            
        }
        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria, ciudad: "Bogota", pais: "Colombia");
            CargarCursos();
            CargarAsignaturas();                               
            CargarEvaluaciones();

        }

        private void CargarEvaluaciones()
        {
            throw new NotImplementedException();
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignatura> listaDeAsignaturas = new List<Asignatura>() {
                    new Asignatura { Nombre = "Matamática" },
                    new Asignatura { Nombre = "Educación Física" },
                    new Asignatura { Nombre = "Castellano" },
                    new Asignatura { Nombre = "Ciencias Naturales" }
                };
                curso.Asignaturas = listaDeAsignaturas;
            }
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 = {"Alba","Felipe","Eusebio","Farid","Donald","Alvaro","Nicolás"};            
            string[] nombre2 = {"Freddy","Anabel","Rick","Murty","Silvana","Diomedes","Teodoro"};
            string[] apellido1 = {"Ruiz","Sarmiento","Uribe","Maduro","Trump","Toledo","Herrera"};

            var listaDeAlumnos = from n1 in nombre1
                                 from n2 in nombre2
                                 from a1 in apellido1
                                 select new Alumno { Nombre = $"{n1} {n2} {a1}"};
                        
            return listaDeAlumnos.OrderBy( (al) => al.UniqueId ).Take(cantidad).ToList();  
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>() {
                new Curso() { Nombre = "101", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "201", Jornada = TiposJornada.Mañana },
                new Curso { Nombre = "301", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "401", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "501", Jornada = TiposJornada.Mañana },
                new Curso { Nombre = "502", Jornada = TiposJornada.Tarde }
            };
            
            Random rnd = new Random();            
            foreach (var curso in Escuela.Cursos)
            {
                int cantidadRandom = rnd.Next(5,20);
                curso.Alumnos = GenerarAlumnosAlAzar(cantidadRandom);
            }
        }
    }
}