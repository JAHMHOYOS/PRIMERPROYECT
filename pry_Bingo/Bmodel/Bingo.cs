using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pry_Bingo.Bmodel
{
    public class Bingo
    {
        public int Valor;
        public bool respu;
        public void CartonA()
        {
          bool encontra=false;

            BingoEntity bina = new BingoEntity();
            int[,] MtcarA = new int[5,5];

            MtcarA[0,0] = bina.B7;
            MtcarA[0, 1] = bina.B16;
            MtcarA[0,2] = bina.B45;
            MtcarA[0,3] = bina.B58;
            MtcarA[0,4] = bina.B63;
            MtcarA[1, 0] = bina.B2;
            MtcarA[1, 1] = bina.B23;
            MtcarA[1, 2] = bina.B34;
            MtcarA[1, 3] = bina.B55;
            MtcarA[1, 4] = bina.B70;
            MtcarA[2, 0] = bina.B13;
            MtcarA[2, 1] = bina.B18;
            MtcarA[2, 2] = 0;
            MtcarA[2, 3] = bina.B46;
            MtcarA[2, 4] = bina.B71;
            MtcarA[3, 0] = bina.B14;
            MtcarA[3, 1] = bina.B28;
            MtcarA[3, 2] = bina.B40;
            MtcarA[3, 3] = bina.B60;
            MtcarA[3, 4] = bina.B62;
            MtcarA[4, 0] = bina.B8;
            MtcarA[4, 1] = bina.B25;
            MtcarA[4, 2] = bina.B41;
            MtcarA[4, 3] = bina.B56;
            MtcarA[4, 4] = bina.B69;

            for (int filas  = 0; filas  < 5 ; filas ++)
            {
                for (int col = 0; col < 5; col++)
                {
                    if (MtcarA[filas,col]== Valor)
                    {
                        encontra = true;
                    }
                }
            }

            if (encontra==true)
            {
                respu = true;
            }
            

        }

        public void CartonB()
        {
            BingoEntity binb = new BingoEntity();
            int[,] MtcarB = new int[4, 4];
            MtcarB[0, 0] = binb.B5;
            MtcarB[0, 1] = binb.B24;
            MtcarB[0, 2] = binb.B36;
            MtcarB[0, 3] = binb.B50;
            MtcarB[0, 4] = binb.B73;
            MtcarB[1, 0] = binb.B13;
            MtcarB[1, 1] = binb.B27;
            MtcarB[1, 2] = binb.B40;
            MtcarB[1, 3] = binb.B59;
            MtcarB[1, 4] = binb.B68;
            MtcarB[2, 0] = binb.B9;
            MtcarB[2, 1] = binb.B18;
            MtcarB[2, 2] = 0;
            MtcarB[2, 3] = binb.B46;
            MtcarB[2, 4] = binb.B64;
            MtcarB[3, 0] = binb.B12;
            MtcarB[3, 1] = binb.B29;
            MtcarB[3, 2] = binb.B44;
            MtcarB[3, 3] = binb.B55;
            MtcarB[3, 4] = binb.B74;
            MtcarB[4, 0] = binb.B4;
            MtcarB[4, 1] = binb.B22;
            MtcarB[4, 2] = binb.B34;
            MtcarB[4, 3] = binb.B52;
            MtcarB[4, 4] = binb.B69;


        }

        public void CartonC()
        {
            int[,] MtcarC = new int[4, 4];
        }

        public void CartonD()
        {
            int[,] MtcarD = new int[4, 4];
        }

        public void CartonE()
        {
            int[,] MtcarE = new int[4, 4];
        }

        public void CartonF()
        {
            int[,] MtcarF = new int[4, 4];
        }

        public void CartonG()
        {
            int[,] MtcarG = new int[4, 4];
        }

        public void CartonH()
        {
            int[,] MtcarH = new int[4, 4];

        }
    }
}
