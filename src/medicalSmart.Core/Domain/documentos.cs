using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicalSmart.Core.Domain
{
    [Table("documentos")]

    public class documentos
    {
        //[Key]
        public int id_Documento { get; set; }

        [StringLength(30)]
        public string Documentos { get; set; }

        public solicitud solicitud { get; set; }
    }
}
