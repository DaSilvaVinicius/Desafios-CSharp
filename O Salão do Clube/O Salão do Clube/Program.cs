int comprimento = 0;
int largura = 0;
do
{
    string[] dimensoesDoSalao = Console.ReadLine().Split(' ');
    comprimento = int.Parse(dimensoesDoSalao[0]);
    largura = int.Parse(dimensoesDoSalao[1]);

    if (comprimento != 0 && largura != 0)
    {
        int larguraDasTabuas = int.Parse(Console.ReadLine());
        int numDeTabuas = int.Parse(Console.ReadLine());
        string[] comprimentosDasTabuas = Console.ReadLine().Split(' ');

        for (int i = 0; i < numDeTabuas; i++)
        {
            int comprimDaTabua = int.Parse(comprimentosDasTabuas[i]); 
            
        }
    }
} while (comprimento != 0 || largura != 0);
