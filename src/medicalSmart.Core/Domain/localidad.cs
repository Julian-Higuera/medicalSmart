using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicalSmart.Core.Domain
{
    [Table("localidad")]
    public class localidad
    {
        //[Key]
        public int id_localidad { get; set; }

        [StringLength(20)]
        public string nombre_Localidad { get; set; }

        public pacientes pacientes { get; set; }
    }
}
