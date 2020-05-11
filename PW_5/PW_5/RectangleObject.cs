using System.Drawing;

namespace PW_5
{
    class RectangleObject : IDraw
    {
        private Pen pen;

        public RectangleObject()
        {
            pen = new Pen(Color.Red, 6);
        }

        public void Draw(Graphics context, Point location, Size size)
        {
            context.DrawRectangle(pen, new Rectangle(location, size));
        }
    }
}
