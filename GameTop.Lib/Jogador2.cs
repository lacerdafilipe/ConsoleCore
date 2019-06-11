using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Pelé está chutando \n";
        }

        public string Corre()
        {
            return "Pelé está correndo \n";
        }

        public string Passa()
        {
            return "Pelé está passando \n";
        }
    }
}