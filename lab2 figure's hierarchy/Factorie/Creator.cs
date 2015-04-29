using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace oop1_figuer_s_hierarchy
{
    interface ICreator
    {
        IShapeDraw FactoryMetod(Graphics graphics, Pen pen, List<Point> points);
        //public abstract Shape FactoryMetod();
    }

    public class LineCreator : ICreator
    {
        public IShapeDraw FactoryMetod(Graphics graphics,Pen pen,List<Point> points )
        {
            Line line = new Line(graphics,pen,points);
            return new LineDraw(line);
        }
    }
    public class EllipseCreator : ICreator
    {
        public IShapeDraw FactoryMetod(Graphics graphics, Pen pen, List<Point> points)
        {
            Oval oval = new Oval(graphics,pen,points);
            return new EllipseDraw(oval);
        }
    }
    public class RectangleCreator : ICreator
    {
        public IShapeDraw  FactoryMetod(Graphics graphics, Pen pen, List<Point> points)
        {
            Rectangle rectangle = new Rectangle(graphics,pen,points);
            return new RectangleDraw(rectangle);
        }
    }

    public class PolygonCreator : ICreator
    {
        public IShapeDraw FactoryMetod(Graphics graphics, Pen pen, List<Point> points)
        {
            Polygon polygon = new Polygon(graphics, pen, points);

            return new PolygonDraw(polygon);
        }
    }

    public class CircleCreator : ICreator
    {
        public IShapeDraw FactoryMetod(Graphics graphics, Pen pen, List<Point> points)
        {
            Circle circle = new Circle(graphics, pen, points);
            return new EllipseDraw(circle);
        }
    }

    public class SquareCreator : ICreator
    {
        public IShapeDraw FactoryMetod(Graphics graphics, Pen pen, List<Point> points)
        {
            Square square = new Square(graphics, pen, points);
            return new RectangleDraw(square);
        }
    }
}
