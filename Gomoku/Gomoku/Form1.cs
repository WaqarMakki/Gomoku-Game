using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gomoku
{
   
    public partial class GForm : Form
    {
        int dim=5;
        Cell[,] Map;
        Cell C;
        int WC = 5;
        COLOR turn = COLOR.Red;

        public GForm()
        {
            InitializeComponent();
        }

        void setWC()
        {
            WC = 5;
        }


        private void Cell_Click(object sender, EventArgs e)
        {
            Cell C = (Cell)sender;
            C.BackColor = Color.Red;
        }

        void UpdateTurn()
        {
            C.Occupier = turn;
            if (turn == COLOR.Black)
                C.BackColor = Color.Red;
            else
            {
                C.BackColor = Color.Black;
            }
        }

        void TurnChange()
        {
            if (turn == COLOR.Red)
                turn = COLOR.Black;
            else
            {
                turn = COLOR.Red;
            }

        }

        private void Init()
        {
            Grid.Controls.Clear();
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    if (dim <= 10)
                    {
                        C = new Cell(Grid.Height / dim - 10, Grid.Width / dim - 10);
                    }
                    else
                    {
                        C = new Cell(Grid.Height / dim - 6, Grid.Width / dim - 6);
                    }
                    Map[i, j] = C;

                    if (HVsH.Checked == true)
                    {
                        C.Click += new System.EventHandler(WhenCellSelectedH_Vs_H);
                    }
                    else if (HVsM.Checked == true)
                    {
                        C.Click += new System.EventHandler(WhenCellSelectedH_Vs_M);
                    }
                    Grid.Controls.Add(C);
                }
            }
        }

        void WhenCellSelectedH_Vs_H(object sender, EventArgs e)
        {
            C = (Cell)sender;
            if(C.Occupier != COLOR.White)
            {
                MessageBox.Show("Invalid Move!!");
                return;
            }
            UpdateTurn();
            if (isWin(turn))
            {
                TurnChange();
                MessageBox.Show(turn.ToString() + " Wins!!");
                Grid.Controls.Clear();
            }
            else if(isDraw())
            {
                MessageBox.Show("Draw!!");
                Grid.Controls.Clear();
            }
            TurnChange();
        }

        bool isDraw()
        {
            for (int i = 0; i < dim;i++)
            {
                for(int j=0;j<dim;j++)
                {
                    if (Map[i, j].Occupier == COLOR.White)
                        return false;
                }
            }
                return true;
        }

        void WhenCellSelectedH_Vs_M(object sender, EventArgs e)
        {
            C = (Cell)sender;
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    if (C.Occupier != COLOR.White)
                    {
                        MessageBox.Show("Invalid Move!!");
                        return;
                    }
                }
                else
                    ComputersMove();

                UpdateTurn();
                if (isWin(turn))
                {
                    TurnChange();
                    MessageBox.Show(turn.ToString() + " Wins!!");
                    Grid.Controls.Clear();
                }
                else if (isDraw())
                {
                    MessageBox.Show("Draw!!");
                    Grid.Controls.Clear();
                }
                TurnChange();
            }
        }

        void ComputersMove()
        {
            if (!Stop_Opponent() && !ComputerWin())
                Random();
        }

        void Random()
        {
            int r,c;
            Random rand = new Random();
            do
            {
                r = rand.Next(0, dim - 1);
                c = rand.Next(0, dim - 1);
            } while (!is_Valid(r, c));
            Map[r, c].Occupier = turn;
            C = Map[r, c];
        }

        bool ComputerWin()
        {
            for (; WC >= 1; WC--)
            {
                for (int ri = 0; ri < dim; ri++)
                {
                    for (int ci = 0; ci < dim; ci++)
                    {
                        if (Map[ri, ci].Occupier == COLOR.White)
                        {
                            Map[ri, ci].Occupier = turn;
                            if (isWin(turn))
                            {
                                Map[ri, ci].Occupier = COLOR.White;
                                C = Map[ri, ci];
                                return true;
                            }
                            else
                                Map[ri, ci].Occupier = COLOR.White;
                        }
                    }
                }
            }
            setWC();
            return false;
        }

        bool Stop_Opponent()
        {
                TurnChange();
                for (; WC >= 1; WC--)
                {
                    for (int ri = 0; ri < dim; ri++)
                    {
                        for (int ci = 0; ci < dim; ci++)
                        {
                            if (Map[ri, ci].Occupier == COLOR.White)
                            {
                                Map[ri, ci].Occupier = turn;
                                if (isWin(turn))
                                {
                                    setWC();
                                    Map[ri, ci].Occupier = COLOR.White;
                                    C = Map[ri, ci];
                                    TurnChange();
                                    return true;
                                }
                                else
                                    Map[ri, ci].Occupier = COLOR.White;
                            }
                        }
                    }
                }
                setWC();
                TurnChange();
                return false;
        }

        bool is_Valid(int r,int c)
        {
            if (Map[r, c].Occupier != COLOR.White)
                return false;
            return true;
        }

        bool HorizontalWin(int r,int c, COLOR turn)
        {
            if (c + WC > dim)
                return false;
            for (int i = 0; i < WC; i++)
            {
                if (Map[r, c + i].Occupier != turn)
                    return false;
            }
            return true;
        }

        bool VerticalWin(int r,int c,COLOR turn)
        {
            if (r + WC > dim)
                return false;
            for (int i = 0; i < WC;i++)
            {
                if (Map[r + i, c].Occupier != turn)
                    return false;
            }
            return true;
        }

        bool DiagonalL2R(int r,int c,COLOR turn)
        {
            if (r + WC > dim || c + WC > dim)
                return false;
            for (int i = 0; i < WC;i++)
            {
                if (Map[r + i, c + i].Occupier != turn)
                    return false;
            }
            return true;
        }

        bool DiagonalR2L(int r, int c, COLOR turn)
        {
            int count = 0;
            for (int i = 0; (i < WC) && (i < dim - r) && (c - i >= 0); i++)
            {
                if (Map[r + i, c - i].Occupier != turn)
                    break;
                else
                    count++;
            }
            return (count == WC);
        }

        bool Did_I_Win(COLOR turn,int r,int c)
        {
            return (HorizontalWin(r, c, turn) || VerticalWin(r, c, turn) || DiagonalL2R(r, c, turn) || DiagonalR2L(r, c, turn));
        }

        bool isWin(COLOR turn)
        {
            for(int i=0;i<dim;i++)
            {
                for(int j=0;j<dim;j++)
                {
                    if(Did_I_Win(turn,i,j))
                        return true;
                }
            }
            return false;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (Fivex5.Checked == true)
                dim = 5;
            else if (Tenx10.Checked == true)
                dim = 10;
            else if (Fifteenx15.Checked == true)
                dim = 15;
            else
            {
                MessageBox.Show("Please Select an Option..!!");
                return;
            }
            Map = new Cell[dim, dim];
            Init();
        }
    }
}