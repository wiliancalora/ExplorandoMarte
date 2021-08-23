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

        public string Explorar(Planalto planalto)
        {

            //criar o planalto ADD


            //criar as sondas ADD
            foreach (var sonda in planalto.Sonda)
            {
                //_sondaAppService.Insert(planalto.Sonda.FirstOrDefault());

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

                            sonda.VerificarTrajetoSonda(planalto.Limite.x, planalto.Limite.y);

                            sonda.Movimentar();
                            break;
                    }
                }
            }



            //enviar instrucoes

            return planalto.Sonda.FirstOrDefault().GetPosicaoFinal();
        }
    }
}
