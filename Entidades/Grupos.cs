using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Grupos
    {
        [Key]
        public int GrupoId { get; set; }

        public string Nombre { get; set; }

        public List<Estudiantes> Estudiantes { get; set; }

        public Grupos()
        {
            this.Estudiantes = new List<Estudiantes>();
        }

        public Grupos(int grupoId, string nombreGrupo)
        {
            this.GrupoId = grupoId;

            this.Nombre = nombreGrupo;

            this.Estudiantes = new List<Estudiantes>();
        }
    }
}
