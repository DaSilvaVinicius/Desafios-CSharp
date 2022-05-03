﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_Salão_do_Clube.Entities
{
    internal class Tabua
    {
        public int Largura { get; set; }
        public int Comprimento { get; set; }

        public Tabua(int larguraEmCM, int comprimentoEmM)
        {
            Largura = larguraEmCM / 100;
            Comprimento = comprimentoEmM;
        }
    }
}
