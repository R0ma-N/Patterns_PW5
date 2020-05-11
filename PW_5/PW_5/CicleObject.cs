using System.Drawing;

namespace PW_5
{
    class CicleObject : IDraw
    {
        private Pen pen;

        public CicleObject()
        {
            pen = new Pen(Color.Blue, 6);
        }

        public void Draw(Graphics context, Point location, Size size)
        {
            context.DrawEllipse(pen, new Rectangle(location, size));
        }
    }
}
