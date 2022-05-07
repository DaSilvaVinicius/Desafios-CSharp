using O_Salão_do_Clube.Entities;

namespace O_Salão_do_Clube.Services
{
    static class TabuasDoadas
    {
        public static void UtilizadasNaObra(List<Tabua> listaDeTabuas)
        {
            int tabuasInstaladasVertical = 0;
            int tabuasInstaladasHorizontal = 0;
            string direcao = "Vertical";
            while (direcao != null)
            {
                int tabuasInstaladas = 0;
                List<Tabua> tabuasNaoUsadas = new List<Tabua>(listaDeTabuas);
                double areaSalaoSemTabua = Salao.Area;


                while (areaSalaoSemTabua > 0 && tabuasNaoUsadas.Count > 0)
                {
                    Tabua maiorTabua = tabuasNaoUsadas.OrderByDescending(tabua => tabua.Comprimento).First();
                    tabuasNaoUsadas.Remove(maiorTabua);

                    if ((maiorTabua.Comprimento == Salao.Comprimento && direcao == "Vertical") || (maiorTabua.Comprimento == Salao.Largura && direcao == "Horizontal"))
                    {
                        areaSalaoSemTabua -= maiorTabua.Area;
                        tabuasInstaladas++;
                    }
                    else
                    {
                        Tabua tabuaComplementar = tabuasNaoUsadas.FirstOrDefault(tabua => tabua.Comprimento + maiorTabua.Comprimento == Salao.Comprimento
                        && direcao == "Vertical"
                        || tabua.Comprimento + maiorTabua.Comprimento == Salao.Largura
                        && direcao == "Horizontal");

                        if (tabuaComplementar != null)
                        {
                            areaSalaoSemTabua -= (maiorTabua.Area + tabuaComplementar.Area);
                            tabuasInstaladas += 2;
                            tabuasNaoUsadas.Remove(tabuaComplementar);
                        }
                    }
                }

                if (direcao == "Vertical")
                {
                    if (areaSalaoSemTabua > 0)
                        tabuasInstaladasVertical = 0;
                    else
                        tabuasInstaladasVertical = tabuasInstaladas;
                    direcao = "Horizontal";
                }
                else if (direcao == "Horizontal")
                {
                    if (areaSalaoSemTabua > 0)
                        tabuasInstaladasHorizontal = 0;
                    else
                        tabuasInstaladasHorizontal = tabuasInstaladas;
                    direcao = null;
                }
            }
           
            if (0 < tabuasInstaladasVertical && tabuasInstaladasVertical < tabuasInstaladasHorizontal
                || tabuasInstaladasHorizontal == 0 && tabuasInstaladasVertical > 0)
            {
                int menorUsoDeTabuas = tabuasInstaladasVertical;
                Console.WriteLine(menorUsoDeTabuas);
            }
            else if (0 < tabuasInstaladasHorizontal && tabuasInstaladasHorizontal <= tabuasInstaladasVertical
               || tabuasInstaladasVertical == 0 && tabuasInstaladasHorizontal > 0)
            {
                int menorUsoDeTabuas = tabuasInstaladasHorizontal;
                Console.WriteLine(menorUsoDeTabuas);
            }
            else
                Console.WriteLine("Impossivel");
        }
    }
}
