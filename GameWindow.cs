using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class GameWindow : Form
    {
        List<NPCBox> invaders = new List<NPCBox>();
        PlayerBox plrBox = new PlayerBox();

        public GameWindow()
        {
            InitializeComponent();
            Settings settings = new Settings(pbCanvas.Size.Width, pbCanvas.Size.Height);
            invaders.Add(new NPCBox(10, 20));
            invaders.Add(new NPCBox(50, 20));
            invaders.Add(new NPCBox(100, 20));
            invaders.Add(new NPCBox(300, 20));
            invaders[invaders.Count - 1].canvasWidth = settings.maxWidth;
            plrBox.canvasWidth = settings.maxWidth;
            gameTimer.Interval = settings.gameSpeed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            NPCBox.MoveInvaders(invaders);
            plrBox.MovePlayer();
            pbCanvas.Invalidate();
        }

        private void KeyPressed(object sender, KeyEventArgs e) {Input.ChangeState(e.KeyCode, true);}

        private void KeyNotPressed(object sender, KeyEventArgs e) {Input.ChangeState(e.KeyCode, false);}


        private void UpdateGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            foreach(NPCBox npc in invaders)
                canvas.FillRectangle(npc.GetColour(), new Rectangle(npc.GetXPosition(),
                                     npc.GetYPosition(),npc.GetWidth(), npc.GetHeight()));

            canvas.FillRectangle(plrBox.GetColour(), new Rectangle(plrBox.GetXPosition(), plrBox.GetYPosition(), plrBox.GetWidth(), plrBox.GetHeight()));
        }

        private void Eject(object sender, KeyPressEventArgs e)
        {
            if (Input.KeyPress(Keys.Space) && invaders.Count > 0)
                invaders.RemoveAt(invaders.Count - 1);
        }
    }
}
