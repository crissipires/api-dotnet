using System;
using Microsoft.AspNetCore.Mvc;

namespace heroku.api.ViewModels
{
    public class Filtro
    {
        [FromQuery(Name = "data_inicial")] 
        public DateTime DataAtendimentoInicial { get; set; }
        [FromQuery(Name = "data_final")] 
        public DateTime DataAtendimentoFinal { get; set; }
        [FromQuery(Name = "codigo_unidade_prisional")]
        public long? UnidadePrisionalId { get; set; }
        [FromQuery(Name = "codigo_defensor")]
        public string DefenseorId { get; set; }
        [FromQuery(Name = "page_number")]
        public int? PageNumber { get; set; }
        [FromQuery(Name = "page_size")]
        public int? PageSize { get; set; }
    }
}