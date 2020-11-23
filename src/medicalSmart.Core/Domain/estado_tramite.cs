using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicalSmart.Core.Domain
{
    [Table("estado_tramite")]
    public class estado_tramite
    {
        //[Key]
        public int id_Tamite { get; set; }

        [StringLength(30)]
        public string estado_Tramite { get; set; }

        public solicitud solicitud { get; set; }
    }
}
