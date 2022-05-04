﻿using System;
using O_Salão_do_Clube.Entities;
using O_Salão_do_Clube.Services;

CalcularQuantasTabuas calcular = new();
do
{
    string[] dimensoesDoSalao = Console.ReadLine().Split(' ');
    Salao.Comprimento = int.Parse(dimensoesDoSalao[0]);
    Salao.Largura = int.Parse(dimensoesDoSalao[1]);


    if (Salao.Comprimento != 0 && Salao.Largura != 0)
    {
        int larguraDasTabuas = int.Parse(Console.ReadLine());
        int numDeTabuas = int.Parse(Console.ReadLine());
        string[] comprimentoDasTabuas = Console.ReadLine().Split(' ');

        for (int i = 0; i < numDeTabuas; i++)
        {
            int comprimDaTabua = int.Parse(comprimentoDasTabuas[i]);

            calcular.AddToList(new Tabua(larguraDasTabuas, comprimDaTabua));
        }
    }

    calcular.Conta();
} while (Salao.Comprimento != 0 && Salao.Largura != 0);


