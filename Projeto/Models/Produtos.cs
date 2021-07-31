using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Models
{
    public class Produtos
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O Nome precisa ser preenchido!!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O Estoque precisa ser preenchido!!")]
        public int Estoque { get; set; }
        [Range(1,double.MaxValue, ErrorMessage = "O valor precisa ser positivo")]
        public decimal Valor { get; set; }
    }
}
