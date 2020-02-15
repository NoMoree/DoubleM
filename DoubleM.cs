using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleMTask
{
    public class DoubleM
    {
        private int n;
        private int lineLenght;
        private IList<bool[]> Lines;

        public DoubleM(int n)
        {
            this.n = n;

            this.InitLines();

            // this.CalculateDraw();


            Console.WriteLine(this.ToString());
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
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            StringBuilder sb;

            for (int line = 0; line < n + 1; line++)
            {
                sb = new StringBuilder();
                sb.AppendFormat("lenght({0,3})", Lines[line].Length);
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

                // TODO: change
                // result.AppendLine("" + sb + sb);
                result.AppendLine("" + sb);
            }

            return result.ToString();
        }
    }
}