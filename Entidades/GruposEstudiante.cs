using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class GruposEstudiante
    {
        [Key]
        public int  Id { get; set; }

        public int GrupoId { get; set; }

        public int EstudianeId{ get; set; }
    }
}
