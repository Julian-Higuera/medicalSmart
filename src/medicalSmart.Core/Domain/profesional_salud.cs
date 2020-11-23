using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicalSmart.Core.Domain
{
    [Table("profesional_salud")]
    public class profesional_salud
    {
        //[Key]
        public int id_profesional { get; set; }

        [StringLength(11)]
        public string no_documentopro { get; set; }

        [StringLength(2)]
        public string Tipo_Documento { get; set; }

        public int cod_Prestador { get; set; }

        [StringLength(20)]
        public string pronombre_1 { get; set; }

        [StringLength(20)]
        public string pronombre_2 { get; set; }

        [StringLength(20)]
        public string proapellido_1 { get; set; }

        [StringLength(20)]
        public string proapellido_2 { get; set; }

        [StringLength(20)]
        public string Correo { get; set; }

        [StringLength(11)]
        public string Telefono { get; set; }

        public int id_Profesion { get; set; }
        public profesion profesion { get; set; }

        public int id_Especialidad { get; set; }
        public especialidad especialidad { get; set; }

        public int id_rol { get; set; }
        public Roles Roles { get; set; }

        [StringLength(30)]
        public string contraseña { get; set; }

        public pacientes pacientes { get; set; }
    }
}
