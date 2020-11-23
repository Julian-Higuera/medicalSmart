using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicalSmart.Core.Domain
{
    [Table("egreso_efectivo")]
    public class egreso_efectivo
    {
        public int id_Egreso { get; set; }

        public int id_Proveedor { get; set; }
        public proveedores proveedores { get; set; }

        public DateTime Fecha_Egreso { get; set; }

        [StringLength(80)]
        public string descripcion_Egreso { get; set; }

        public int valor_Egreso { get; set; }
    }
}
