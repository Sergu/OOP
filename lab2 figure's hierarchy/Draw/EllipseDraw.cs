using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1_figuer_s_hierarchy
{
    public class EllipseDraw : IShapeDraw
    {
        private Oval oval;
        private int x, y, width, height;
        public EllipseDraw(Oval oval)
        {
            this.oval = oval;
        }
        public void Draw(System.Drawing.Graphics g)
        {
            Editor.Analysis(oval.points, out x, out y, out width, out height);
            if (oval is Circle)
            {
                if (width > height)
                    width = height;
                else
                    height = width;
            }
            g.DrawEllipse(this.oval.pen,this.x,this.y,this.width,this.height);
        }
    }
}
