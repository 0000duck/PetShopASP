using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PetShopASP.Models
{
    public class Login
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(40)]
        [Required(ErrorMessage = "Campo Obrigratório")]
        public string Username { get; set; }
        [StringLength(40)]
        [Required(ErrorMessage = "Campo Obrigratório")]
        public string Senha { get; set; }
        [StringLength(200)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Campo Obrigratório")]
        public string Email { get; set; }
        [StringLength(200)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Campo Obrigratório")]
        public string Email_suporte { get; set; }
        [StringLength(12)]
        [Required(ErrorMessage = "Campo Obrigratório")]
        public string Cel { get; set; }
        [StringLength(20)]
        [Required(ErrorMessage = "Campo Obrigratório")]
        public string Hierarquia { get; set; }
    }
}
