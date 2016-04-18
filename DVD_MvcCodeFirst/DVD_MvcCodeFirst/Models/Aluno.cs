using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DVD_MvcCodeFirst.Models
{
    public class Aluno
    {
        [Key]
        public int IDAluno { get; set; }

        [Display(Name = "Professor")]
        public int IDProfessor { get; set; }

        [Required(ErrorMessage = "Nome obrigatorio")]
        [MaxLength(50), MinLength(5)]
        public string NomeAluno { get; set; }


        [Required(ErrorMessage = "Email obrigatorio")]
        [StringLength(250)]
        public string Email { get; set; }


        [Range(1980, 2020, ErrorMessage = "O ano deverá ser entre 1980 e 2020")]
        public int Ano { get; set; }

        public bool Aprovado { get; set; }
        public DateTime Inscricao { get; set; }


        //Lazy loading = add virtual 
        [Display(Name = "Professor")]
        public virtual Professor Professor { get; set; }


    }
}