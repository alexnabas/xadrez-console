using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro t, Cor c) : base(t, c)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
