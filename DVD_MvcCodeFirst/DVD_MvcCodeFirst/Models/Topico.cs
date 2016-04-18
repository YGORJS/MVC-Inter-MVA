using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DVD_MvcCodeFirst.Models
{
    public class Topico
    {
        [Key]
        public int IDTopico { get; set; }

        [Display(Name = "Professor")]
        public int IDProfessor { get; set; }

        [Required(ErrorMessage = "Descrição obrigatorio")]
        [MaxLength(100), MinLength(5)]
        public string Descricao { get; set; }

        [Display(Name = "Professor")]
        public Professor Professor { get; set; }



    }
}