﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Web_24BM.Models
{
    [Table("Persona")]
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        [StringLength(18)]
        public string CURP { get; set;}
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

    }
}
