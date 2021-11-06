using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows;

namespace GridGame
{
    public partial class frm2048 : Form
    {
        cGridGame m_gridGame;

        private void Call_SlideBoxes(MoveGridItems Direction)
        {
            m_gridGame.SlideBoxes(Direction);
            DrawGame();
        }

        private void DrawGame()
        {
            bool bRedraw = true;
            bool AddRandomValue = false;

            while (bRedraw)
            {
                m_gridGame.Draw(pbxGrid, out bRedraw);
                if (bRedraw)
                    AddRandomValue = true;
            }

            if ( AddRandomValue )
            {
                m_gridGame.AddRandomValue();
                m_gridGame.Draw(pbxGrid, out _ );
            }

            lblScorePoints.Text = m_gridGame.Score.ToString();
            if ( m_gridGame.HighestNumber >= 2048 )
            {
                lblObjective.Text = "You Won!\nKeep Playing";
            }
        }

        public frm2048()
        {
            cGlobals.globalInst = this;

            InitializeComponent();
            m_gridGame = new cGridGame(pbxGrid, 4, 4);
            cboBy.SelectedIndex = 0;
            
        }

        private void frm2048_Shown(object sender, EventArgs e)
        {
            m_gridGame.DebugSetup();
            m_gridGame.Draw(pbxGrid, out bool Redraw);
        }

        private void frm2048_Paint(object sender, PaintEventArgs e)
        {
            DrawGame();
        }

        private void frm2048_ResizeEnd(object sender, EventArgs e)
        {
            m_gridGame.ResizeGrid();
            m_gridGame.Draw(pbxGrid, out bool Redraw);
        }

        private void frm2048_SizeChanged(object sender, EventArgs e)
        {
            int iOffsetAmount = 0;
            pbxGrid.Bounds = new Rectangle(5, 85, this.Width - 25, this.Height - 130);
            //square box
            if ( pbxGrid.Height > pbxGrid.Width )
            {
                iOffsetAmount = (pbxGrid.Height - pbxGrid.Width);
                pbxGrid.Height -= iOffsetAmount;
            }
            else if ( pbxGrid.Height < pbxGrid.Width )
            {
                iOffsetAmount = (pbxGrid.Width - pbxGrid.Height);
                pbxGrid.Width -= iOffsetAmount;
                pbxGrid.Left += iOffsetAmount / 2;
            }

            m_gridGame.ResizeGrid();
            m_gridGame.Draw(pbxGrid, out bool Redraw);
        }

        private void frm2048_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    Call_SlideBoxes(MoveGridItems.Up);
                    break;
                case Keys.Down:
                    Call_SlideBoxes(MoveGridItems.Down);
                    break;
                case Keys.Left:
                    Call_SlideBoxes(MoveGridItems.Left);
                    break;
                case Keys.Right:
                    Call_SlideBoxes(MoveGridItems.Right);
                    break;
            }
        }


        private IPoint ptStart = (-1, -1);
        bool bMovedAlready = false;

       

        public void frm2048_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            IPoint ptDelta = (0, 0);
            IPoint ptCurrent = (0, 0);
            if ( e.Button == MouseButtons.Left && false == bMovedAlready )
            {
                ptCurrent = (e.X, e.Y);
                if ( ptStart == (-1,-1) )
                {
                    ptStart = (e.X, e.Y);
                }

                ptDelta = ptCurrent - ptStart;
                if ( Math.Abs(ptDelta.Y) > 25)
                {
                    if ( ptDelta.Y > 0 )
                    {
                        Call_SlideBoxes(MoveGridItems.Down);
                    }
                    else
                    {
                        Call_SlideBoxes(MoveGridItems.Up);
                    }
                    bMovedAlready = true;
                }
                else if ( Math.Abs(ptDelta.X) > 25 )
                {
                    if ( ptDelta.X > 0)
                    {
                        Call_SlideBoxes(MoveGridItems.Right);
                    }
                    else
                    {
                        Call_SlideBoxes(MoveGridItems.Left);
                    }
                    bMovedAlready = true;
                }
            }
            else
            {
                ptStart = (-1, -1);
                bMovedAlready = false;
            }
        }

        public void frm2048_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            bMovedAlready = false;
            ptStart = (-1, -1);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            m_gridGame.UndoMove();
            DrawGame();
        }

        private void cboBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBy.SelectedIndex != -1)
            {
                var cboBy_Text = cboBy.SelectedItem.ToString();
                int iBaseValue = (cboBy_Text == null ? 2 : int.Parse(cboBy_Text));

                m_gridGame.UseBaseValue = iBaseValue;
                m_gridGame.UpdateGameBaseValue(iBaseValue);
                m_gridGame.Draw(pbxGrid, out _ );
            }
        }

        private void cboBy_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cboBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }//form

    public static class cGlobals
    {
        public static frm2048 globalInst = null;
    }

}//namespace
