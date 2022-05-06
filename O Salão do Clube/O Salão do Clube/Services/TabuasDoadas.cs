using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using O_Salão_do_Clube.Entities;



namespace O_Salão_do_Clube.Services
{
    class TabuasDoadas
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

        public void UtilizadasNaObra()
        {
            int tabuasInstaladasVert = 0;
            List<Tabua> tabuasNaoUsadas = new List<Tabua>(listaDeTabuas);
            double larguraSalaoSemTabua = Salao.Largura;           

            while (larguraSalaoSemTabua > 0 && tabuasNaoUsadas.Count > 0)
            {
                Tabua maiorTabua = tabuasNaoUsadas.OrderByDescending(tabua => tabua.Comprimento).FirstOrDefault();

                if (maiorTabua.Comprimento == Salao.Comprimento)
                {
                    larguraSalaoSemTabua -= maiorTabua.Largura;
                    tabuasInstaladasVert++;
                    tabuasNaoUsadas.Remove(maiorTabua);
                }
                else 
                {
                    foreach (Tabua tabua in tabuasNaoUsadas)
                    {
                        if (maiorTabua.Comprimento + tabua.Comprimento == Salao.Comprimento)
                        {
                            larguraSalaoSemTabua -= maiorTabua.Largura;
                            tabuasInstaladasVert += 2;
                            tabuasNaoUsadas.Remove(tabua);
                            tabuasNaoUsadas.Remove(maiorTabua);
                        }
                    }
                    if (tabuasNaoUsadas.Contains(maiorTabua))
                        tabuasNaoUsadas.Remove(maiorTabua);
                }

            }

            int tabuasInstaladasHoriz = 0;
            tabuasNaoUsadas = new List<Tabua>(listaDeTabuas);
            double ComprimentoSalalaoSemTabua = Salao.Comprimento;

            while (ComprimentoSalalaoSemTabua > 0 && tabuasNaoUsadas.Count > 0)
            {
                Tabua maiorTabua = tabuasNaoUsadas.OrderByDescending(tabua => tabua.Comprimento).FirstOrDefault();

                if (maiorTabua.Comprimento == Salao.Largura)
                {
                    ComprimentoSalalaoSemTabua -= maiorTabua.Largura;
                    tabuasInstaladasHoriz++;
                    tabuasNaoUsadas.Remove(maiorTabua);
                }
                else
                {
                    foreach (Tabua tabua in tabuasNaoUsadas)
                    {
                        if (maiorTabua.Comprimento + tabua.Comprimento == Salao.Largura)
                        {
                            ComprimentoSalalaoSemTabua -= maiorTabua.Largura;
                            tabuasInstaladasHoriz += 2;
                            tabuasNaoUsadas.Remove(tabua);
                            tabuasNaoUsadas.Remove(maiorTabua);
                        }
                    }
                    if (tabuasNaoUsadas.Contains(maiorTabua))
                        tabuasNaoUsadas.Remove(maiorTabua);
                }
            }

            if (tabuasInstaladasVert > tabuasInstaladasHoriz)
                Console.WriteLine(tabuasInstaladasVert);
            else
                Console.WriteLine(tabuasInstaladasHoriz);
        }
    }
}
