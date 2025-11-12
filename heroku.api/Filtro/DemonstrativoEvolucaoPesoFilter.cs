using System;
using System.Linq.Expressions;

namespace heroku.api.Filtros
{
    public class DemonstrativoEvolucaoPesoFilter
    {
        public int? CodigoTipoCartorio { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataTermino { get; set; }
    }
}
