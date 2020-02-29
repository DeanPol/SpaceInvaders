using System.Drawing;

namespace SpaceInvaders
{
    class NPCBox : Box
    {
        public int npcSpeed = 10; 
        public NPCBox() : base (10,10,20,20,100,Direction.Right, Brushes.Red){}
        public void MoveBox()
        {
            
            if (XPos == canvasWidth - boxWidth)
            {
                if (verticalDrop == 0)
                {
                    direction = Direction.Left;
                    verticalDrop = boxHeight;
                }
                else
                    direction = Direction.Down;
            }
            else if (XPos == 0)
                if (verticalDrop == 0)
                {
                    direction = Direction.Right;
                    verticalDrop = boxHeight;
                }
                else
                    direction = Direction.Down;

            switch (direction)
            {
                case Direction.Right:
                    XPos += npcSpeed;
                    break;
                case Direction.Left:
                    XPos -= npcSpeed;
                    break;
                case Direction.Down:
                    YPos += npcSpeed;
                    verticalDrop -= boxHeight;
                    break;
            }
        }
    }
}
