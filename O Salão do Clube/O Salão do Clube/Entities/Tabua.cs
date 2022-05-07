namespace O_Salão_do_Clube.Entities
{
    internal class Tabua
    {
        public double Largura { get; private set; }
        public int Comprimento { get; private set; }
        public double Area { get; private set; }

        public Tabua(int larguraEmCM, int comprimentoEmM)
        {
            Largura = (double)(larguraEmCM / 100.00);
            Comprimento = comprimentoEmM;
            Area = Largura * Comprimento;
        }
    }
}
