using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FDS_SITE.Models
{

    public partial class Cuestionario
    {
        [NotMapped]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CodigoCuestionario { get; set; }

        public string Descripcion { get; set; }
        public int? TipoCuestionario { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public bool? Estado { get; set; }


        public Cuestionario(){
            FechaCreacion = DateTime.UtcNow;
        }
    }

}
