using System.Drawing;
using System.Windows.Forms;

namespace SpaceInvaders
{
    class PlayerBox : Box
    {
        public int playerSpeed = 5;
        public PlayerBox() : base(360,540,20,20,0, Direction.None, Brushes.Blue) { }

        public void MovePlayer()
        {
            if (Input.KeyPress(Keys.Right) && (XPos + playerSpeed <= canvasWidth - boxWidth))
                XPos += playerSpeed;

            else if (Input.KeyPress(Keys.Left) && (XPos - playerSpeed >= 0))
                XPos -= playerSpeed;
        }

    }
}
