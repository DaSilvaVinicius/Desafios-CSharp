using O_Salão_do_Clube.Entities;

int comprimentoDoSalão = 0;
int larguradoSalão = 0;
List<Tabua> listaDeTabuas = new List<Tabua>();
do
{
    string[] dimensoesDoSalao = Console.ReadLine().Split(' ');
    comprimentoDoSalão = int.Parse(dimensoesDoSalao[0]);
    larguradoSalão = int.Parse(dimensoesDoSalao[1]);

    if (comprimentoDoSalão != 0 && larguradoSalão != 0)
    {
        int larguraDasTabuas = int.Parse(Console.ReadLine());
        int numDeTabuas = int.Parse(Console.ReadLine());
        string[] comprimentoDasTabuas = Console.ReadLine().Split(' ');

        for (int i = 0; i < numDeTabuas; i++)
        {
            int comprimDaTabua = int.Parse(comprimentoDasTabuas[i]);

            listaDeTabuas.Add(new Tabua(larguraDasTabuas, comprimDaTabua));
        }
    }
} while (comprimentoDoSalão != 0 || larguradoSalão != 0);
