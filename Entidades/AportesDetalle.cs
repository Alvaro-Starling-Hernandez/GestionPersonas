using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPersonas.Entidades
{
    public class AportesDetalle
    {
        [Key]
        public int Id { get; set; }
        public int TipoAporteId { get; set; }
        public int AporteId { get; set; }
        public float Valor { get; set; }


        [ForeignKey("TipoAporteId")]
        public virtual TiposAportes TiposAporte { get; set; }
    }
}
