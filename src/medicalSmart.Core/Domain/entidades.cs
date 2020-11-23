using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicalSmart.Core.Domain
{
    [Table("entidades")]
    public class entidades
    {
        //[Key]
        public int id_Entidad { get; set; }

        [StringLength(30)]
        public string Tramites { get; set; }

        public solicitud solicitud { get; set; }
    }
}
