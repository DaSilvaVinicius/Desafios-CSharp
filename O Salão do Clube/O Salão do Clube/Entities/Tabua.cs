namespace O_Salão_do_Clube.Entities
{
    internal class Tabua
    {
        public double Largura { get; set; }
        public int Comprimento { get; set; }

        public Tabua(int larguraEmCM, int comprimentoEmM)
        {
            Largura = (double)(larguraEmCM / 100.00);
            Comprimento = comprimentoEmM;
        }
    }
}
