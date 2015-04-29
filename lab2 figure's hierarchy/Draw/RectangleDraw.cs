using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1_figuer_s_hierarchy
{
    class RectangleDraw : IShapeDraw
    {
        private Rectangle rectangle;
        private int x, y, width, height;
        public RectangleDraw(Rectangle rectangle)
        {
            this.rectangle = rectangle;
        }
        public void Draw(System.Drawing.Graphics g)
        {
            Editor.Analysis(rectangle.points, out x, out y, out width, out height);
            if (rectangle is Square)
            {
                if (width > height)
                    width = height;
                else
                    height = width;
            }
            g.DrawRectangle(rectangle.pen, x, y, width, height);
        }
    }
}
