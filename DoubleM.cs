using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleMTask
{
    // n=7

    // DrawOutsideM();      //draws '1'
    // DrawBottomSide();    //draws '2'
    // DrawTopSide();       //draws '3'

    // 1111111*******3333333*******1111111
    // 111111*********33333*********111111
    // 11111***********333***********11111
    // 1111*************3*************1111
    // 111*******2*************2*******111
    // 11*******222***********222*******11
    // 1*******22222*********22222*******-
    // *******2222222*******2222222*******

    // if n = n.max
    //(10000+1)*7*10000= ~700 070 000 chars

    public class DoubleM
    {
        private int n;
        private int lineLenght;
        private IList<bool[]> Lines;

        public DoubleM(int n)
        {
            if (n < 3 || n > 10000)
                throw new System.ArgumentException("Parameter must be between 3 < 'n' < 10 000.", "n");
            if (n % 2 == 0)
                throw new System.ArgumentException("Parameter 'n' must be odd number", "n");

            this.n = n;
            this.InitLines();

            this.CalculateDraw();
        }

        private void InitLines()
        {
            this.lineLenght = 5 * this.n;
            this.Lines = new List<bool[]>();
            for (int i = 0; i < this.n + 1; i++)
                this.Lines.Add(new bool[lineLenght]);
        }

        private void CalculateDraw()
        {
            this.DrawOutsideM();
            this.DrawBottomSide();
            this.DrawTopSide();
        }

        private void DrawOutsideM()
        {
            for (int line = 0; line < this.n; line++)
            {
                for (int pos = 0; pos < this.n - line; pos++)
                {
                    Lines[line][pos] = true;
                    Lines[line][lineLenght - pos - 1] = true;
                }
            }
        }

        private void DrawTopSide()
        {
            int midLine = this.n / 2 + 1;
            int possOffset = this.n + this.n / 2;

            for (int line = 0; line < midLine; line++)
            {
                for (int pos = 0; pos < 1 + line * 2; pos++)
                {
                    Lines[midLine + line][pos + possOffset - line] = true;
                    Lines[midLine + line][lineLenght - 1 - pos + line - possOffset] = true;
                }
            }
        }

        private void DrawBottomSide()
        {
            int midLine = this.n / 2 + 1;
            int possOffset = this.n * 2;
            for (int i = 0; i < midLine; i++)
            {
                for (int poss = 0; poss < (midLine - i) * 2 - 1; poss++)
                {
                    Lines[i][poss + possOffset + i] = true;
                }
            }
        }

        public void PrintToConsole()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            StringBuilder sb;

            for (int line = 0; line < n + 1; line++)
            {
                sb = new StringBuilder();
                for (int pos = 0; pos < lineLenght; pos++)
                {
                    if (!Lines[line][pos])
                    {
                        sb.Append('*');
                    }
                    else
                    {
                        sb.Append('-');
                    }
                }

                result.AppendLine("" + sb + sb);
            }

            return result.ToString();
        }
    }
}