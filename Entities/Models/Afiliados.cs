using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiteParcial.Entities.Models
{
    public class Afiliados : IdentityBase
    {
        [Required]
        [MaxLength(100)]
        public string NombreCompleto { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string CUIT { get; set; }
    }
}