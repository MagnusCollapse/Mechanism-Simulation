using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Mech
{
    public class Model
    {
        private double w1 = 0.5;
        public double W1
        {
            get
            {
                return w1;
            }
            set
            {
                w1 = value;
            }
        }

        private double w2 = 0.25;
        public double W2
        {
            get
            {
                return w2;
            }
            set
            {
                w2 = value;
            }
        }

        private int radiusSmall = 25;
        public int r1
        {
            get
            {
                return radiusSmall;
            }
            set
            {
                radiusSmall = value;
            }
        }

        private int radiusBig = 100;
        public int R1
        {
            get
            {
                return radiusBig;
            }
            set
            {
                radiusBig = value;
            }
        }

        List<Point> myListA { get; set; } = new List<Point>();
        List<Point> myListB { get; set; } = new List<Point>();

        public bool Picture(bool cl, Graphics g, Point center, double t)
        {
            const int numSpokes = 4;

            g.Clear(Color.White);

            // Calculate the current angle of rotation for the big wheel
            double theta2 = W2 * t;

            // Calculate the current angle of rotation for the line connecting the centers
            double theta1 = (W1+W2) * t;

            // Calculate the center of the small wheel based on the angle of rotation
            double cx1 = center.X + (R1 - r1) * Math.Cos(theta1);
            double cy1 = center.Y + (R1 - r1) * Math.Sin(theta1);
            Point center1 = new Point((int)cx1, (int)cy1);

            // Draw the line connecting the centers
            g.DrawLine(Pens.Black, center, center1);

            g.DrawEllipse(Pens.Black, center.X - (int)R1, center.Y - (int)R1, (int)(2 * R1), (int)(2 * R1));

            // Draw the small wheel
            g.DrawEllipse(Pens.Black, center1.X - (int)r1, center1.Y - (int)r1, (int)(2 * r1), (int)(2 * r1));

            // Draw the big wheel
            for (int i = 0; i < numSpokes; i++)
            {
                double angle = theta2 + (2 * Math.PI / numSpokes) * i;
                double x = center.X + R1 * Math.Cos(angle);
                double y = center.Y + R1 * Math.Sin(angle);
                Point spokeEnd = new Point((int)x, (int)y);
                g.DrawLine(Pens.Black, center, spokeEnd);
            }

            //double theta3 = ((R1 / r1) * theta1)/(Math.PI*2);
            double theta3 = ((R1 / r1) *W1*t) / (Math.PI);

            // Draw the small wheel
            for (int i = 0; i < numSpokes*2; i++)
            {
                double angle = theta3 + (2 * Math.PI / numSpokes) * i;
                double x = center1.X + r1 * Math.Cos(-angle); 
                double y = center1.Y + r1 * Math.Sin(-angle);
                Point spokeEnd = new Point((int)x, (int)y);
                g.DrawLine(Pens.Black, center1, spokeEnd);
            }

            return false;
        }
        public void Traek (Graphics g, Point center, double t, bool newGraph, bool a, bool b)
        {

            double theta1 = (W1 + W2) * t;
            double theta3 = ((R1 / r1) * W1 * t) / (Math.PI);

            double cx1 = center.X + (R1 - r1) * Math.Cos(theta1);
            double cy1 = center.Y + (R1 - r1) * Math.Sin(theta1);
            Point center1 = new Point((int)cx1, (int)cy1);


            
            double angle = theta3 + (2 * Math.PI / 4) * 1;
            double x = center1.X + r1 * Math.Cos(-angle); 
            double y = center1.Y + r1 * Math.Sin(-angle);
            Point A = new Point((int)x, (int)y);

            double angle1 = theta3 + (2 * Math.PI / 4) * 3;
            double x1 = center1.X + r1 * Math.Cos(-angle1); 
            double y1 = center1.Y + r1 * Math.Sin(-angle1);
            Point B = new Point((int)x1, (int)y1);

            if (newGraph)
            {
                myListA.Clear();
                myListA.Add(A);
                myListB.Clear();
                myListB.Add(B);
                return;
            }

            myListA.Add(A);
            myListB.Add(B);
            Pen p;
            if (a)
            {
                p = new Pen(Color.Red);
                Point[] myMas = myListA.ToArray();
                for (int i = 0; i<2; i++)
                    g.DrawCurve(p, myMas);
            }
            if (b)
            {
                p = new Pen(Color.Green);
                Point[] myMas = myListB.ToArray();
                for (int i = 0; i < 2; i++)
                    g.DrawCurve(p, myMas);
            }
        }
    }
}
