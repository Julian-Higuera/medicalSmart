using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicalSmart.Core.Domain
{
    [Table("proveedores")]
    public class proveedores
    {
        //[Key]
        public int id_Proveedor { get; set; }
        [StringLength(20)]
        public string nombre_Proveedor { get; set; }

        public egreso_efectivo egreso_efectivo { get; set; }
    }
}
