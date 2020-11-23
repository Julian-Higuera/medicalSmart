using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicalSmart.Core.Domain
{
    [Table("cuenta_cobro")]
    public class cuenta_cobro
    {
        public int Cuentacobro { get; set; }

        public int id_profesional { get; set; }
        public profesional_salud profesional_salud { get; set; }

        public DateTime Fecha_Cuenta { get; set; }

        [StringLength(80)]
        public string Concepto { get; set; }

        public int Valor { get; set; }

        public int Total_Cuentacobro { get; set; }


        [StringLength(10)]
        public string Estado_Cc { get; set; }


        public int id_Ingreso { get; set; }
        public ingreso_efectivo ingreso_efectivo { get; set; }
    }
}
