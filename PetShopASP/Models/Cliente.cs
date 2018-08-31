using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PetShopASP.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(40)]
        [Required(ErrorMessage = "Campo Obrigratório")]
        public string Nome { get; set; }
        [StringLength(200)]
        [Required(ErrorMessage = "Campo Obrigratório")]
        public string Sobrenome { get; set; }
        [StringLength(14)]
        [Required(ErrorMessage = "Campo Obrigratório")]
        public string CPF { get; set; }
        [StringLength(9)]
        [Required(ErrorMessage = "Campo Obrigratório")]
        public string CEP { get; set; }
        [Required(ErrorMessage = "Campo Obrigratório")]
        public int Numero { get; set; }
        [StringLength(40)]
        [Required(ErrorMessage = "Campo Obrigratório")]
        public string Complemento { get; set; }
        [StringLength(11)]
        public string Telefone { get; set; }
        [StringLength(12)]
        [Required(ErrorMessage = "Campo Obrigratório")]
        public string Celular { get; set; }
        [StringLength(200)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Campo Obrigratório")]
        public string Email_primario { get; set; }
        [StringLength(200)]
        [DataType(DataType.EmailAddress)]
        public string Email_secundario { get; set; }



    }
}
