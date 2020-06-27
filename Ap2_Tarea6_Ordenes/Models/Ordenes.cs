using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ap2_Tarea6_Ordenes.Validaciones;

namespace Ap2_Tarea6_Ordenes.Models
{
    public class Ordenes
    {
        [Key]
        [IdValidaciones]
        public int OrdenId { get; set; }

        [FechaValidacion]
        public DateTime Fecha { get; set; }
        public int SuplidorId { get; set; }
        public decimal Monto { get; set; }

        [ForeignKey("OrdenId")]
        public virtual List<OrdenesDetalle> OrdenDetalle { get; set; }

        public Ordenes()
        {
            OrdenId = 0;
            Fecha = DateTime.Now;
            SuplidorId = 0;
            Monto = 0.0m;

            OrdenDetalle = new List<OrdenesDetalle>();
        }
    }
}
