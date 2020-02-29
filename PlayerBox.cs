using System.Windows.Forms;

namespace SpaceInvaders
{
    class PlayerBox : Box
    {

       public PlayerBox() : base(30,30,20,20,0, Direction.None) { }

        public void MovePlayer()
        {
            if (Input.KeyPress(Keys.Right))
                XPos += 5;

            else if (Input.KeyPress(Keys.Left))
                XPos -= 5;
        }

    }
}
