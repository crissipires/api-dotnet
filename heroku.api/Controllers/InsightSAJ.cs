using heroku.api.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace heroku.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class InsightSAJ : ControllerBase
    {
        [HttpGet("GetFilter")]
        public ActionResult GetFilter()
        {
            //return Content("{  \"competencia\": [    {      \"codigo\": 1,      \"descricao\": \"Reconocimiento de Verdad y Responsabilid\"    },    {      \"codigo\": 2,      \"descricao\": \"Amnistía e Indulto\"    },    {      \"codigo\": 3,      \"descricao\": \"Definición de Situaciones Jurídicas\"    },    {      \"codigo\": 4,      \"descricao\": \"TP - Reconocimiento de Verdad\"    },    {      \"codigo\": 5,      \"descricao\": \"TP - Ausencia de Reconocimiento\"    }  ]}");
            return Content(Query.filtro);
        }

        [HttpGet("GetReport")]
        public ActionResult GetReport([FromQuery] Filtro _)
        {
            //return Content("{   \"cabecalho\":{      \"filtros\":[         {            \"rotulo\":\"Período\",            \"descricao\":\"20/08/2021 00:00:00 até 02/09/2021 23:59:59\"         }      ],      \"titulo\":\"Relatório evolução peso\",      \"instituicao\":\"Teste nome tribunal\",      \"emissao\":\"Emitido em: 13/09/2021 12:12:48\",      \"pagina\":\"Página\",      \"parametros\":\"Parâmetros do relatório\",      \"processo\":\"Processo\",     \"competencia\":\"Competência\",      \"classe\":\"Classe\",      \"assunto\":\"Assunto\",      \"vaga\":\"Vaga\",      \"vara\":\"Vara\",      \"peso_grupo\":\"Peso no grupo\",      \"contemplada\":\"Contemplada\",     \"quantidade_recebida\":\"Qt. recebido\",	  \"data\":\"Data\",	  \"operacao\":\"Operação\"   },   \"processos\":[      {         \"data\":\"10/09/2021 17:07:06\",         \"operacao\":\"Redistribuição - Prevención porVaga\",         \"numero_processo\":\"0000500-94.2019.0.00.0001\",         \"detalhes\":{            \"atual\":[               {                  \"classe\":\"Juzgamiento ordinario\",                 \"vaga\":\"JuanJosé Cantillo Pushaina\",                  \"vara\":\"Sala de Amnistía e Indulto\",                  \"grupo_peso\":\"Juzgamiento ordinario\",                  \"vagas\":[                     {                        \"descricao\":\"Juan José Cantillo Pushaina\",                        \"peso\":\"0\"                     }                  ]               }            ]         }      },      {         \"data\":\"13/09/2021 10:41:45\",         \"operacao\":\"Evolução de classe\",         \"numero_processo\":\"0000500-94.2019.0.00.0001\",         \"detalhes\":{            \"anterior\":[               {                  \"classe\":\"Juzgamiento ordinario\",                  \"vaga\":\"Juan José Cantillo Pushaina\",                  \"vara\":\"Sala de Amnistía e Indulto\",                 \"grupo_peso\":\"Tratamiento especial Fuerza Publica\",                  \"vagas\":[                     {                        \"descricao\":\"Juan José Cantillo Pushaina\",                        \"peso\":\"1\"                     },                     {                        \"descricao\":\"Marcela Giraldo Muñoz\",                        \"peso\":\"0\"                     },                     {                        \"descricao\":\"Xiomara Cecilia Balanta Moreno\",                        \"peso\":\"0\"                     },                     {                        \"descricao\":\"Pedro JulioMahecha Ávila\",                        \"peso\":\"0\"                     },                     {                        \"descricao\":\"Lily Andrea Rueda Guzmán\",                        \"peso\":\"0\"                     },                     {                        \"descricao\":\"Alexandra Sandoval Mantilla\",                        \"peso\":\"0\"                     }                  ]               }            ],            \"atual\":[               {                 \"classe\":\"Tratamiento especial Fuerza Publica\",                  \"vaga\":\"Juan José Cantillo Pushaina\",                  \"vara\":\"Sala de Amnistía e Indulto\",                  \"grupo_peso\":\"Tratamientoespecial Fuerza Publica\",                  \"vagas\":[                     {                        \"descricao\":\"Juan José Cantillo Pushaina\",                        \"peso\":\"1\"                     },                     {                        \"descricao\":\"Marcela Giraldo Muñoz\",                        \"peso\":\"0\"                     },                     {                        \"descricao\":\"Xiomara Cecilia Balanta Moreno\",                        \"peso\":\"0\"                     },                     {                        \"descricao\":\"Pedro JulioMahechaÁvila\",                        \"peso\":\"0\"                     },                     {                        \"descricao\":\"Lily Andrea Rueda Guzmán\",                        \"peso\":\"0\"                     },                     {                        \"descricao\":\"Alexandra Sandoval Mantilla\",                        \"peso\":\"0\"                     }                  ]               }            ]         }      }   ]}");

            return Content(Query.consulta);
        }

        [HttpGet("GetDadosNotificacao")]
        public ActionResult GetDados()
        {
            return Content(Query.consulta2); }
    }
}