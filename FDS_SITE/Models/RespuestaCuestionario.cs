using System;
using System.Collections.Generic;

namespace FDS_SITE.Models
{
    public partial class RespuestaCuestionario
    {
        public int CodigoRespuesta { get; set; }
        public int? CodigoCuestionario { get; set; }
        public int? TipoControl { get; set; }
        public string RespString { get; set; }
        public int? RespInteger { get; set; }
        public DateTime? RespDatetime { get; set; }
        public bool? RespBoolean { get; set; }
        public decimal? RespMoney { get; set; }
    }
}
