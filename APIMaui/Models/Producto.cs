using System;
using System.ComponentModel.DataAnnotations;

namespace APIMaui.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        [Required]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }
        [Required]
        public int cantidad { get; set; }

        //public List<Compra> Compras { get; set; }


    }
}

