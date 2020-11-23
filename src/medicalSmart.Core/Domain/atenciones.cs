using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace medicalSmart.Core.Domain
{
    [Table("atenciones")]
    public class atenciones
    {
        public int id_Atencion { get; set; }

        public int id_paciente { get; set; }
        public pacientes pacientes { get; set; }

        public DateTime Fecha_Atencion { get; set; }

        public string id_codigo_CIE { get; set; }
        public codigo_diagnostico_cie codigo_diagnostico_cie { get; set; }

        public int id_codigo_CUPS { get; set; }
        public codigo_procedimiento_cups codigo_procedimiento_cups { get; set; }

        public int Valor_Atencion { get; set; }
    }
}
