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
        public int canvasHeight;

        //Constructors
        public Box(int xpos, int ypos, int boxH, int boxW, int drop, Direction dir, Brush colour) 
        {
            XPos = xpos;
            YPos = ypos;
            boxHeight = boxH;
            boxWidth = boxW;
            this.verticalDrop = drop;
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
