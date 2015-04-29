﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace oop1_figuer_s_hierarchy
{
    public class Rectangle : Shape
    {
        public Rectangle(Graphics graphics, Pen pen,List<Point> points)
        {
            this.points = points;
            this.graphics = graphics;
            this.pen = pen;
        }
    }
}
