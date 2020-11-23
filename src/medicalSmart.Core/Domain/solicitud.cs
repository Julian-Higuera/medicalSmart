using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicalSmart.Core.Domain
{
    [Table("solicitud")]
    public class solicitud
    {
        public int id_Solicitud { get; set; }

        public int id_profesional { get; set; }
        public profesional_salud profesional_salud { get; set; }

        public int id_Documento { get; set; }
        public documentos documentos { get; set; }

        public int id_Entidad { get; set; }
        public entidades entidades { get; set; }

        public int id_Tramite { get; set; }
        public estado_tramite estado_tramite { get; set; }

        public int codigo { get; set; }
        public imagen imagen { get; set; }
    }
}
