using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1_figuer_s_hierarchy
{
    class PolygonDraw : IShapeDraw
    {
        private Polygon polygon;
        public PolygonDraw(Polygon polygon)
        {
            this.polygon = polygon;
        }
        public void Draw(System.Drawing.Graphics g)
        {
            g.DrawPolygon(polygon.pen, polygon.points.ToArray());
        }
    }
}
