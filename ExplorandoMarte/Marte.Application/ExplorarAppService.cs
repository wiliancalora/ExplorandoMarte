using Marte.Application.Interfaces;
using Marte.Domain.Entities;
using Marte.Domain.Interfaces.Services;
using Marte.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marte.Application
{
    public class ExplorarAppService : IExplorarAppService
    {
        readonly ISondaAppService _sondaAppService;

        public ExplorarAppService(ISondaAppService sondaAppService) 
        {
            _sondaAppService = sondaAppService;
        }

        public List<string> Explorar(Planalto planalto)
        {

            //Validar se o planalto ja existe

            //Adicionar o planalto caso não existe

            //Adicionar as sondas

            
            List<string> retorno = new List<string>();

            foreach (var sonda in planalto.Sonda)
            {
                foreach (char instrucao in sonda.Instrucoes)
                {
                    switch (instrucao)
                    {
                        case 'L':
                            sonda.RotacionarEsquerda();
                            break;
                        case 'R':
                            sonda.RotacionarDireita();
                            break;
                        case 'M':

                            if (sonda.TrajetoSondaValido(planalto.Limite.x, planalto.Limite.y))
                            {
                                sonda.Movimentar();
                            }
                            break;
                    }
                }

                retorno.Add(sonda.GetPosicaoFinal(planalto.Limite.x, planalto.Limite.y));

            }

            return retorno;
        }
    }
}
