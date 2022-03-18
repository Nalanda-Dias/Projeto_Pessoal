using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Projeto_Pessoal.Models
{
    public class ClMetas
    {
        [DisplayName("Código")]
        public string Codigo { get; set; }

        [DisplayName("Titulo")]
        public string Titulo { get; set; }
        [DisplayName("Data de Inicio")]
        public string Data_Inicial { get; set; }

        [DisplayName("Data Final")]
        public string Data_Final { get; set; }

        [DisplayName("Descrição")] 
        public string Descricao { get; set; }
    }
}