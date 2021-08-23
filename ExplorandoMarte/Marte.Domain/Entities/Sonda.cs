using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marte.Domain.Entities
{
    public class Sonda : BaseEntity
    {
        public Sonda(int x, int y, int direcao)
        {
            this.Coordenada = new Coordenada(x,y);
            this.IdSonda = Guid.NewGuid().ToString();
            this.Direcao = (Dir)direcao;
        }
        public enum Dir
        {
            N = 0,
            E = 1,
            S = 2,
            W = 3
        }

        public string IdSonda { get; }
        private Coordenada Coordenada { get; }
        private Dir Direcao { get; set; }
        
        public string Instrucoes { get; set; }

        public void Movimentar()
        {
            switch (Direcao)
            {
                case Dir.N:
                    Coordenada.y++;
                    break;
                case Dir.E:
                    Coordenada.x++;
                    break;
                case Dir.S:
                    Coordenada.y--;
                    break;
                case Dir.W:
                    Coordenada.x--;
                    break;
            }
        }

        public bool TrajetoSondaValido(int x, int y)
        {

            if (Coordenada.x > x ||  Coordenada.y > y || Coordenada.x < 0 || Coordenada.y < 0) 
            {
                return false;
            }

            return true;
        }

        public void RotacionarEsquerda()
        {
            if(this.Direcao == Dir.N)
            {
                this.Direcao = Dir.W;
                return;
            }

            this.Direcao -= 1;
            
        }

        public void RotacionarDireita()
        {
            if (this.Direcao == Dir.W)
            {
                this.Direcao = Dir.N;
                return;
            }

            this.Direcao += 1;
        }

        public string GetPosicaoFinal(int x, int y)
        {
            if (!TrajetoSondaValido(x, y))
            {
                return "Resultado: A sonda " + IdSonda + " está fora da área do planalto";
            }

            return "Resultado: A sonda " + IdSonda + " está na posição " + Coordenada.x + " " + Coordenada.y + " " + Direcao;  
        }
    }
}
