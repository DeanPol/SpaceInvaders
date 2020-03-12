using System;
using System.Collections.Generic;
using System.Drawing;

namespace SpaceInvaders
{
    class NPCBox : Box
    {
        public int npcSpeed = 10; 
        public NPCBox(int XPos, int YPos) : base (XPos, YPos, 20, 20, 100, Direction.Right, Brushes.Red){}
        public static void MoveInvaders(List<NPCBox> invaders)
        {
            NPCBox leader = invaders[invaders.Count - 1];
            NPCBox last = invaders[0];

            if (leader.XPos == leader.canvasWidth - leader.boxWidth)
            {
                if (leader.verticalDrop == 0)
                {
                    foreach (NPCBox npc in invaders)
                    {
                        npc.direction = Direction.Left;
                        npc.verticalDrop = leader.boxHeight;
                    }
                }
                else
                    foreach (NPCBox npc in invaders)
                        npc.direction = Direction.Down;
            }
            else if (last.XPos == 0)
                if (last.verticalDrop == 0)
                {
                    foreach (NPCBox npc in invaders)
                    {
                        npc.direction = Direction.Right;
                        npc.verticalDrop = last.boxHeight;
                    }
                }
                else
                    foreach (NPCBox npc in invaders)
                        npc.direction = Direction.Down;

            foreach (NPCBox npc in invaders)
            {
                switch (npc.direction)
                {
                    case Direction.Right:
                        npc.XPos += npc.npcSpeed;
                        break;
                    case Direction.Left:
                        npc.XPos -= npc.npcSpeed;
                        break;
                    case Direction.Down:
                        npc.YPos += npc.npcSpeed;
                        npc.verticalDrop -= npc.boxHeight;
                        break;
                }
            }
        }
    }
}
