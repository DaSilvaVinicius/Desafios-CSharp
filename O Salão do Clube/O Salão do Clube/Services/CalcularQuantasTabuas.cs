using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using O_Salão_do_Clube.Entities;



namespace O_Salão_do_Clube.Services
{
    class CalcularQuantasTabuas
    {
        List<Tabua> listaDeTabuas = new();

        public void AddToList(Tabua tabua)
        {
            listaDeTabuas.Add(tabua);
        }

        public void RemoveFromList(Tabua tabua)
        {
            listaDeTabuas.Remove(tabua);
        }

        public void Conta()
        {
            int tabuasUsadas = 0;
            List<Tabua> tabuasNaoUsadas = new List<Tabua>(listaDeTabuas);
            double larguraDoSalaoNaoPreenchido = Salao.Largura;
            double ComprimentoDoSalaoNaoPreenchido = Salao.Comprimento;
            
            while (larguraDoSalaoNaoPreenchido > 0)
            {
                Tabua maiorTabua = tabuasNaoUsadas.OrderByDescending(tabua => tabua.Comprimento).FirstOrDefault();

                if (maiorTabua.Comprimento == Salao.Comprimento)
                {
                    larguraDoSalaoNaoPreenchido -= maiorTabua.Largura;
                    tabuasUsadas++;
                    tabuasNaoUsadas.Remove(maiorTabua);
                }
                else
                {
                    foreach (Tabua tabua in tabuasNaoUsadas)
                    {
                        if (maiorTabua.Comprimento + tabua.Comprimento == Salao.Comprimento)
                        {
                            larguraDoSalaoNaoPreenchido -= maiorTabua.Largura;
                            tabuasUsadas += 2;
                            tabuasNaoUsadas.Remove(tabua);
                            tabuasNaoUsadas.Remove(maiorTabua);
                        }
                    }
                }
            }
        }
    }
}
