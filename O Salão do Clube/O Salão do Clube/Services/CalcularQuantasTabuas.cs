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
            Tabua maiorTabua = listaDeTabuas.OrderByDescending(tabua => tabua.Comprimento)
                .FirstOrDefault();
            
            if (maiorTabua.Comprimento == Salao.Comprimento || maiorTabua.Comprimento == Salao.Largura)
                Console.WriteLine(maiorTabua.Comprimento);
        }
    }
}
