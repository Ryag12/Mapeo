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
    }
}
