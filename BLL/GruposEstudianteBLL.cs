using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;
namespace BLL
{
   public class GruposEstudianteBLL
    {
        public static List<GruposEstudiante> GetList(int grupoId)
        {
            var lista = new List<GruposEstudiante>();
            using (var conexion = new RegistroyMapeoDb())
            {
                try
                {
                    lista = conexion.GruposEstudiante.Where(Ge => Ge.GrupoId == grupoId).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return lista;
        }

        public static bool Insertar( List<GruposEstudiante> nuevo)
        {
            bool obtener = false;
            using (var conexion = new RegistroyMapeoDb())
            {
                try
                {
                    foreach (var estudiante in nuevo)
                    {
                        conexion.GruposEstudiante.Add(estudiante);
                    }             
                    conexion.SaveChanges();

                    obtener = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return obtener;
        }

        public static List<GruposEstudiante> GetListEst(int estudianteId)
        {
            var lista = new List<GruposEstudiante>();
            using (var conexion = new RegistroyMapeoDb())
            {
                try
                {
                    lista =  conexion.GruposEstudiante.Where(Ge => Ge.EstudianteId == estudianteId).ToList();
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
