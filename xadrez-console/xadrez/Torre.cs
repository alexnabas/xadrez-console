using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro t, Cor c) : base(t, c)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
