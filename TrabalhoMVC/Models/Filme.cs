using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TrabalhoMVC.Models
{
    public class Filme
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Ano { get; set; }
        public string Diretor { get; set; }
    }
}
