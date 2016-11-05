using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;
namespace BLL
{
    public class GruposBLL
    {
        public static bool Insertar(Grupos nuevoGrupo)
        {
            bool obtener = false;
            using (var conexion = new RegistroyMapeoDb())
            {
                try
                {
                    conexion.Grupo.Add(nuevoGrupo);

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

        public static Grupos Buscar(int grupoId)
        {
            var grupo = new Grupos();
            using (var conexion = new RegistroyMapeoDb())
            {
                try
                {
                    grupo = conexion.Grupo.Find(grupoId);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return grupo;
        }
        public static List<Grupos> GetList()
        {
            var lista = new List<Grupos>();
            using (var conexion = new RegistroyMapeoDb())
            {
                try
                {
                    lista = conexion.Grupo.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;
        }

        public static List<Grupos>GetList(List<GruposEstudiante> ge)
        {
            var lista = new List<Grupos>();

            using (var conexion = new RegistroyMapeoDb())
            {
                try
                {

                    foreach (var estudiante in ge)
                    {
                        lista.Add(conexion.Grupo.Find(estudiante.GrupoId));
                    }
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
