using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple_E01
{

    class Shape
    {
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }

        public virtual double Area(Shape rec)
        {
            return rec.Width * rec.Height;
        }

        public override string ToString()
        {
            return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
        }
    }

    class Rectangle : Shape
    {

    }

    class Square : Shape
    {
        public override double Width { set { base.Width = base.Height = value; } }

        public override double Height { set { base.Width = base.Height = value; } }
    }

    class Triangle : Shape
    {
        public override double Area(Shape rec)
        {
            return base.Area(rec) * 0.5;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape rc = new Rectangle();
            rc.Width = 5;
            rc.Height = 10;
            //Console.WriteLine($"{rc} area is {rc.Area(rc)}");
            Show(rc);
            Shape sq = new Square();
            sq.Width = 5;
            //Console.WriteLine($"{sq} area is {sq.Area(sq)}");
            Show(sq);

            Triangle tr = new Triangle();
            tr.Width = 5;
            tr.Height = 10;
            Show(tr);
        }

        static void Show(Shape shape)
        {
            Console.WriteLine($"{shape} area is {shape.Area(shape)}");
        }
    }
}
