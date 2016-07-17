using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DVD_MvcCodeFirst.Models
{
    public class Disciplina
    {
        [Key]
        public int IDDisciplina { get; set; }

        [Required(ErrorMessage = "Obrigatorio")]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        [Display(Name = "Professor")]
        public int IDProfessor { get; set; }

        [Display(Name = "Professor")]
        public virtual Professor Professor { get; set; }
    }
}