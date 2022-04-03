using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gomoku
{
    enum COLOR { White,Red,Black};
    class Cell:Button
    {
        public COLOR Occupier;
        public Cell(int H,int W)
        {
            Occupier = COLOR.White;
            this.Height = H;
            this.Width = W;
        }
    }
}