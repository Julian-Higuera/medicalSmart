using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicalSmart.Core.Domain
{
    [Table("ingreso_efectivo")]
    public class ingreso_efectivo
    {
        public int id_Ingreso { get; set; }

        public DateTime Fecha_Ingreso { get; set; }

        [StringLength(80)]
        public string descripcion_Ingreso { get; set; }

        public int valor_Ingreso { get; set; }

        public cuenta_cobro cuenta_cobro { get; set; }
    }
}
