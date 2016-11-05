using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Entidades;
namespace BLL
{
    public class EstudiantesBLL
    {
        public static bool Insertar(Estudiantes nuevoEst )
        {
            bool obtener = false;
            using (var conexion = new RegistroyMapeoDb())
            {
                try
                {
                    conexion.Estudiantes.Add(nuevoEst);

                    conexion.SaveChanges();

                    obtener = true;
                }
                catch (Exception)
                {

                    throw;
                }

                return obtener;
            }
        }

        public static Estudiantes Buscar(int EstudianteId)
        {
            var estudiante = new Estudiantes();
            using (var conexion = new RegistroyMapeoDb())
            {
                try
                {
                    estudiante = conexion.Estudiantes.Find(EstudianteId);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return estudiante;
        }

        public static List<Estudiantes>GetList()
        {
            var lista = new List<Estudiantes>();
            using (var conexion = new RegistroyMapeoDb())
            {
                try
                {
                    lista = conexion.Estudiantes.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;
        }

        public static List<Estudiantes> GetList(List<GruposEstudiante> ge)
        {
            var lista = new List<Estudiantes>();
            using (var conexion = new RegistroyMapeoDb())
            {
                try
                {
                    foreach (var estudiante in ge)
                    {
                        lista.Add(conexion.Estudiantes.Find(estudiante.EstudianteId));
                    }
                    //lista = conexion.Estudiantes.Where(e => e.EstudianteId == ge)
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;
        }
    }
}
