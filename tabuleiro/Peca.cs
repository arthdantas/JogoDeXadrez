using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    internal class Peca
    {
        public Cor cor { get;protected set; }
        public Posicao posicao  { get; set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Cor cor,  Tabuleiro tab)
        {
            this.cor = cor;
            this.posicao = null;
            this.tab = tab;
            this.qteMovimentos = 0;
        }
    }
}
