using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PetShopASP.Models
{
    public class Pet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(20)]
        [Required(ErrorMessage ="Campo Obrigatório")]
        public string Nome { get; set; }
        [StringLength(20)]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Raca { get; set; }
        [ForeignKey("Especies")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public Especie Especie { get; set; }
        [ForeignKey("Clientes")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public Cliente Dono { get; set; }





    }
}
