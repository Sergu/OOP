using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace oop1_figuer_s_hierarchy
{
    public static class Editor
    {
        public static void Analysis(List<Point> points, out int xmin, out int ymin, out int width, out int height)
        {
            int size = points.Count();
    

            if (points[0].X < points[1].X)
            {
                xmin = points[0].X;
            }
            else
            {
                xmin = points[1].X;
            }
            if (points[0].Y < points[1].Y)
            {
                ymin = points[0].Y;
            }
            else
            {
                ymin = points[1].Y;
            }
            width = Convert.ToInt32(Math.Abs(points[0].X - points[1].X));
            height = Convert.ToInt32(Math.Abs(points[0].Y - points[1].Y));
        }
    }
}
