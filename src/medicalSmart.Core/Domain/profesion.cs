using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicalSmart.Core.Domain
{
    [Table("profesion")]
    public class profesion
    {
        //[Key]
        public int id_Profesion { get; set; }

        [StringLength(20)]
        public string nombre_Profesion { get; set; }

        public profesional_salud profesional_salud { get; set; }
    }
}
