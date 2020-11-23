using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicalSmart.Core.Domain
{
    [Table("pacientes")]
    public class pacientes
    {
        //[Key]
        public int id_paciente { get; set; }

        [StringLength(11)]
        public string no_documentopac { get; set; }


        [StringLength(20)]
        public string pacnombre_1 { get; set; }

        [StringLength(20)]
        public string pacnombre_2 { get; set; }

        [StringLength(20)]
        public string pacapellido_1 { get; set; }

        [StringLength(20)]
        public string pacapellido_2 { get; set; }

        [StringLength(2)]
        public string edad { get; set; }

        [StringLength(20)]
        public string Correo { get; set; }

        [StringLength(11)]
        public string Telefono { get; set; }

        public int id_localidad { get; set; }
        public localidad localidad { get; set; }

        public int id_profesional { get; set; }
        public profesional_salud profesional_salud { get; set; }


        public atenciones atenciones { get; set; }
    }
}
