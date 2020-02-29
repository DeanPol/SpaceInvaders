using System;
using System.Drawing;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class GameWindow : Form
    {
        NPCBox npcBox = new NPCBox();
        PlayerBox plrBox = new PlayerBox();

        public GameWindow()
        {
            InitializeComponent();
            Settings settings = new Settings(pbCanvas.Size.Width, pbCanvas.Size.Height);
            npcBox.canvasWidth = settings.maxWidth;
            plrBox.canvasWidth = settings.maxWidth;
            gameTimer.Interval = settings.gameSpeed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            npcBox.MoveBox();
            plrBox.MovePlayer();
            pbCanvas.Invalidate();
        }

        private void KeyPressed(object sender, KeyEventArgs e) {Input.ChangeState(e.KeyCode, true);}

        private void KeyNotPressed(object sender, KeyEventArgs e) {Input.ChangeState(e.KeyCode, false);}


        private void UpdateGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            canvas.FillRectangle(npcBox.GetColour(), new Rectangle(npcBox.GetXPosition(),
                                                         npcBox.GetYPosition(),
                                                          npcBox.GetWidth(), npcBox.GetHeight()));

            canvas.FillRectangle(plrBox.GetColour(), new Rectangle(plrBox.GetXPosition(), plrBox.GetYPosition(), plrBox.GetWidth(), plrBox.GetHeight()));
        }
    }
}
