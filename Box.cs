using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public enum Direction
    {
        Right,
        Left,
        Down,
        None
    };
    class Box
    {
        //Properties
        protected int XPos { get; set; }
        protected int YPos { get; set; }
        protected int boxHeight { get; set; }
        protected int boxWidth { get; set; }
        protected int drop { get; set; }
        protected Direction direction { get; set; }

        //Constructors
        public Box(int xpos, int ypos, int boxH, int boxW, int drop, Direction dir) 
        {
            XPos = xpos;
            YPos = ypos;
            boxHeight = boxH;
            boxWidth = boxW;
            this.drop = drop;
            direction = dir;
        }

        //Methods
        public int GetXPosition() { return XPos; }
        public int GetYPosition() { return YPos; }
        public int GetHeight() { return boxHeight; }
        public int GetWidth() { return boxWidth; }
    }
}
