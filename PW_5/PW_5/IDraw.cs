using System.Drawing;

namespace PW_5
{
    interface IDraw
    {
        void Draw(Graphics context, Point location, Size size);
    }
}
