using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace medicalSmart.Core.Domain
{
    [Table("imagen")]
    public class imagen
    {
        //[Key]
        public int codigo { get; set; }

        public long img { get; set; }

        public solicitud solicitud { get; set; }
    }
}
