namespace SpaceInvaders
{
    class NPCBox : Box
    {
        public NPCBox() : base (10,10,20,20,100,Direction.Right){}
        public void MoveBox(int screenWidth, int screenHeight)
        {
            int maxXPos = screenWidth - boxWidth;
            int maxYPos = screenHeight;

            if (XPos == maxXPos)
            {
                if (drop == 0)
                {
                    direction = Direction.Left;
                    drop = boxHeight;
                }
                else
                    direction = Direction.Down;
            }
            else if (XPos == 0)
                if (drop == 0)
                {
                    direction = Direction.Right;
                    drop = boxHeight;
                }
                else
                    direction = Direction.Down;

            switch (direction)
            {
                case Direction.Right:
                    XPos++;
                    break;
                case Direction.Left:
                    XPos--;
                    break;
                case Direction.Down:
                    YPos++;
                    drop -= boxHeight;
                    break;
            }
        }
    }
}
