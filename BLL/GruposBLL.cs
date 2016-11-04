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
    }
}
