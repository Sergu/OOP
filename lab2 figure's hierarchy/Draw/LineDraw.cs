using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1_figuer_s_hierarchy
{
    class LineDraw : IShapeDraw
    {
        private Line line;
        public LineDraw(Line line)
        {
            this.line = line;
        }
        public void Draw(System.Drawing.Graphics g)
        {
            g.DrawLine(line.pen, line.points[0], line.points[1]);
        }
    }
}
