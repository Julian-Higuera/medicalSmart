using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicalSmart.Core.Domain
{
    [Table("Roles")]
    public class Roles
    {
        //[Key]
        public int id_rol { get; set; }

        [StringLength(30)]
        public string roles { get; set; }

        public profesional_salud profesional_salud { get; set; }
    }
}
