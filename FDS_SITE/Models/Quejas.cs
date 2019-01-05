using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FDS_SITE.Models
{
    public partial class Quejas
    {
        [NotMapped]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CodigoQueja { get; set; }
        public int CodigoTipo { get; set; }
        public int CodigoDepartamento { get; set; }
        public int CodigoSucursal { get; set; }
        public string Empleado { get; set; }
        public string Queja { get; set; }
        public DateTime Fecha { get; set; }
        public string Ubicacion { get; set; }
        public string Imagen { get; set; }

        public Quejas()
        {
            Fecha = DateTime.UtcNow;
        }
    }
}
