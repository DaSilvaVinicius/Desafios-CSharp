using System;
using System.Linq;
using System.Collections.Generic;
using O_Salão_do_Clube.Entities;
using O_Salão_do_Clube.Services;

namespace O_Salão_do_Clube.Services
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string[] dimensoesDoSalao = Console.ReadLine().Split(' ');
                Salao.Comprimento = int.Parse(dimensoesDoSalao[0]);
                Salao.Largura = double.Parse(dimensoesDoSalao[1]);
                Salao.Area = Salao.Comprimento * Salao.Largura;

                if (Salao.Comprimento != 0 && Salao.Largura != 0)
                {
                    int larguraDasTabuas = int.Parse(Console.ReadLine());
                    int numDeTabuas = int.Parse(Console.ReadLine());
                    string[] comprimentoDasTabuas = Console.ReadLine().Split(' ');

                    List<Tabua> listaDeTabuas = new();
                    for (int i = 0; i < numDeTabuas; i++)
                    {
                        int comprimDaTabua = int.Parse(comprimentoDasTabuas[i]);

                        listaDeTabuas.Add(new Tabua(larguraDasTabuas, comprimDaTabua));
                    }

                    TabuasDoadas.UtilizadasNaObra(listaDeTabuas);
                }
            } while (Salao.Comprimento != 0 && Salao.Largura != 0);
        }
    }
}