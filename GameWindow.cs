using System;
using System.Drawing;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class GameWindow : Form
    {
        NPCBox aiBox = new NPCBox();
        PlayerBox myBox = new PlayerBox();
        Brush ai_Colour = Brushes.Red;
        Brush my_boxColour = Brushes.Blue;

        public GameWindow()
        {
            InitializeComponent();

            gameTimer.Interval = 10;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            aiBox.MoveBox(pbCanvas.Width, pbCanvas.Height);
            myBox.MovePlayer();
            pbCanvas.Invalidate();
        }

        private void KeyPressed(object sender, KeyEventArgs e) {Input.ChangeState(e.KeyCode, true);}

        private void KeyNotPressed(object sender, KeyEventArgs e) {Input.ChangeState(e.KeyCode, false);}

        

        private void UpdateGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            canvas.FillRectangle(ai_Colour, new Rectangle(aiBox.GetXPosition(),
                                                         aiBox.GetYPosition(),
                                                          aiBox.GetWidth(), aiBox.GetHeight()));

            canvas.FillRectangle(my_boxColour, new Rectangle(myBox.GetXPosition(), myBox.GetYPosition(), myBox.GetWidth(), myBox.GetHeight()));
        }


    }
}
