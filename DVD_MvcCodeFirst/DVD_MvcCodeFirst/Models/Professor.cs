using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace DVD_MvcCodeFirst.Models
{
    public class Professor
    {
        [Key, Column(Order= 0)]
        public int IDProfessor { get; set; }

        [Required(ErrorMessage = "Nome Obrigatorio") Column(Order = 1)]
        [MinLength(8, ErrorMessage = "No minimo 8 caracteres")]
        public string Nome { get; set; }

        public string Telefone { get; set; }


        [DisplayFormat(DataFormatString = "{0:n2}",
                        ApplyFormatInEditMode = true,
                        NullDisplayText = "Sem remuneração")]
        [Range(1200, 25000, ErrorMessage = "O salário devera ser entre {0} e {1}")]
        public decimal? Salario { get; set; }

        [Display(Name = "Twitter/Blog")]
        [Column("ContatoDigital", Order = 5)]
        public string TwitterBlog { get; set; }

        public string Materia { get; set; }

        public bool Disponivel { get; set; }


        [DisplayFormat(DataFormatString = "{0:dd/MM/YYYY}")]
        public DateTime? Admissao { get; set; }


        public List<Aluno> Alunos { get; set; }

        public List<Topico> Topicos { get; set; }



    }
}