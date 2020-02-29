namespace SpaceInvaders
{
    class Settings
    {
        public int gameSpeed;
        public int maxWidth;
        public int maxHeight;

        public Settings(int width, int height)
        {
            gameSpeed = 100;
            maxWidth = width;
            maxHeight = height;
        }
    }
}
