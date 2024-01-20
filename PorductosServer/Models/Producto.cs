﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PorductosServer.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [MaxLength(50,ErrorMessage = "El campo {0} debe tener maximo {1} caracteres.")]
        public string Nombre { get; set; } = null!;

        [DataType(DataType.MultilineText)]
        [MaxLength(500, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres.")]
        public string Descripcion { get; set; } = null!;

        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:c2}")]
        public decimal Precio { get; set; } 
    }
}
