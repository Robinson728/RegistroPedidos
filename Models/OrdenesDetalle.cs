using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroPedidos.Models
{
    public class OrdenesDetalle
    {

        [Key]
        public int Id { get; set; }
        public int OrdenId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public double Costo { get; set; }

        [ForeignKey("ProductoId")]
        public virtual Productos DetallesProducto { get; set; }
    }
}
