using System.Collections.Generic;
using System.Drawing;

namespace SpaceInvaders
{
    class NPCBox : Box
    {
        public NPCBox(int XPos, int YPos) : base (XPos, YPos, 20, 20, Brushes.Red){}
        public static void MoveInvaders(List<NPCBox> invaders)
        {
            //if the right-most npc reaches the edge of the screen, everyone starts moving down closer to the player.
            if (invaders[invaders.Count - 1].XPos == invaders[invaders.Count - 1].canvasWidth - invaders[invaders.Count - 1].boxWidth)
            {
                if (invaders[invaders.Count - 1].verticalDrop == 0)
                {
                    foreach (NPCBox npc in invaders)
                    {
                        npc.direction = Direction.Left;
                        npc.verticalDrop = invaders[invaders.Count - 1].boxHeight * 5;
                    }
                }
                else
                    foreach (NPCBox npc in invaders)
                        npc.direction = Direction.Down;
            }
            //if the left-most npc reaches the edge, again everyone moves down.
            else if (invaders[0].XPos == 0)
            {
                if (invaders[0].verticalDrop == 0)
                {
                    foreach (NPCBox npc in invaders)
                    {
                        npc.direction = Direction.Right;
                        npc.verticalDrop = invaders[0].boxHeight * 5;
                    }
                }
                else
                    foreach (NPCBox npc in invaders)
                        npc.direction = Direction.Down;
            }

            foreach (NPCBox npc in invaders)
            {
                switch (npc.direction)
                {
                    case Direction.Right:
                        {
                            npc.XPos += npc.boxWidth;
                            break;
                        }
                    case Direction.Left:
                        {
                            npc.XPos -= npc.boxWidth;
                            break;
                        }
                    case Direction.Down:
                        {
                            npc.YPos += npc.boxWidth;
                            npc.verticalDrop -= npc.boxHeight;
                        }
                        break;
                }
            }
        }
    }
}
