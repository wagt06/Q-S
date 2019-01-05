using System;
using System.Collections.Generic;

namespace FDS_SITE.Models
{
    public partial class DetalleCuestionario
    {
        public int Numero { get; set; }
        public int? CodigoCuestionario { get; set; }
        public string Pregunta { get; set; }
        public string TipoControl { get; set; }
    }
}
