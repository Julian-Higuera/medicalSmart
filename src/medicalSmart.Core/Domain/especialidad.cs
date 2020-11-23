using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicalSmart.Core.Domain
{
    [Table("especialidad")]
    public class especialidad
    {
        //[Key]
        public int id_Especialidad { get; set; }

        [StringLength(20)]
        public string nombre_Especialidad { get; set; }

        public profesional_salud profesional_salud { get; set; }
    }
}
