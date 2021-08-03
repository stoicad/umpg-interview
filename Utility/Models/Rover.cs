namespace Utility.Models
{
    public class Rover
    {
        public char Orientation { get; set; }
        public int XPosition { get; set; }
        public int YPosition { get; set; }

        public void RotateLeft()
        {
            switch (Orientation)
            {
                case 'N':
                    Orientation = 'W';
                    break;
                case 'S':
                    Orientation = 'E';
                    break;
                case 'W':
                    Orientation = 'S';
                    break;
                case 'E':
                    Orientation = 'N';
                    break;

                default:
                    break;
            }
        }

        public void RotateRight()
        {
            switch (Orientation)
            {
                case 'N':
                    Orientation = 'E';
                    break;
                case 'S':
                    Orientation = 'W';
                    break;
                case 'W':
                    Orientation = 'N';
                    break;
                case 'E':
                    Orientation = 'S';
                    break;

                default:
                    break;
            }
        }
    }
}
