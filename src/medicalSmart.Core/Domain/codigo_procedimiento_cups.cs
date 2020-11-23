using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicalSmart.Core.Domain
{
    [Table("codigo_procedimiento_cups")]
    public class codigo_procedimiento_cups
    {
        //[Key]
        public int id_codigo_CUPS { get; set; }

        [StringLength(80)]
        public string descripcion_CUPS { get; set; }

        [StringLength(20)]
        public string categoria_CUPS { get; set; }

        public atenciones atenciones { get; set; }
    }
}
