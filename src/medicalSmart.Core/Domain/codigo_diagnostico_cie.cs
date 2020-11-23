using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicalSmart.Core.Domain
{
    [Table("codigo_diagnostico_cie")]
    public class codigo_diagnostico_cie
    {
        //[Key]

        [StringLength(5)]
        public string id_codigo_CIE { get; set; }

        [StringLength(80)]
        public string descripcion_CIE { get; set; }

        [StringLength(20)]
        public string categoria_CIE { get; set; }

        public atenciones atenciones { get; set; }

    }
}
