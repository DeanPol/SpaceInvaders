using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class Form1 : Form
    {
        NPCBox aiBox = new NPCBox();
        PlayerBox myBox = new PlayerBox();
        Brush ai_Colour = Brushes.Red;
        Brush my_boxColour = Brushes.Blue;

        public Form1()
        {
            InitializeComponent();

            gameTimer.Interval = 10;
            gameTimer.Tick += updateScreen;
            gameTimer.Start();
        }

        private void updateScreen(object sender, EventArgs e)
        {
            aiBox.MoveBox(pbCanvas.Width, pbCanvas.Height);
            myBox.MovePlayer();
            pbCanvas.Invalidate();
        }

        private void keyIsDown(object sender, KeyEventArgs e) {Input.ChangeState(e.KeyCode, true);}

        private void keyIsUp(object sender, KeyEventArgs e) {Input.ChangeState(e.KeyCode, false);}

        

        private void updateGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            canvas.FillRectangle(ai_Colour, new Rectangle(aiBox.GetXPosition(),
                                                         aiBox.GetYPosition(),
                                                          aiBox.GetWidth(), aiBox.GetHeight()));

            canvas.FillRectangle(my_boxColour, new Rectangle(myBox.GetXPosition(), myBox.GetYPosition(), myBox.GetWidth(), myBox.GetHeight()));
        }


    }
}
