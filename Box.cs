using System.Drawing;

namespace SpaceInvaders
{
    public enum Direction
    {
        Right,
        Left,
        Down,
        Up,
        None
    };
    class Box
    {
        //Properties
        protected int XPos;
        protected int YPos;
        protected int boxHeight;
        protected int boxWidth;
        protected int verticalDrop;
        protected Direction direction;
        protected Brush colour;
        public int canvasWidth;

        //Constructors
        public Box(int xpos, int ypos, int boxH, int boxW, Brush colour) 
        {
            XPos = xpos;
            YPos = ypos;
            boxHeight = boxH;
            boxWidth = boxW;
            direction = Direction.Right;
            verticalDrop = boxHeight * 5;
            this.colour = colour;
        }

        public Box(int xpos, int ypos, int boxH, int boxW, Direction dir, Brush colour)
        {
            XPos = xpos;
            YPos = ypos;
            boxHeight = boxH;
            boxWidth = boxW;
            verticalDrop = 0;
            direction = dir;
            this.colour = colour;
        }

        //Methods
        public int GetXPosition() { return XPos; }
        public int GetYPosition() { return YPos; }
        public int GetHeight() { return boxHeight; }
        public int GetWidth() { return boxWidth; }
        public Brush GetColour() { return colour; }
    }
}
