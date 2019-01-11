using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Agent
    {
        double step = 0.1;
        double stepR = 20;

        double fi = 0;
        float r = -500;
        double teta = 0;
        float ScreenHeight;
        float ScreenWidth;
        Graphics AgentGfx;
        

        public Agent (Point3D Point)
	{
            AgentGfx = g;
            _pov = Point;
	}
        
        Point3D _pov = new Point3D(0, 0, 0);

        public Agent ()
	    {

	    }

        public Point3D povRac() {
            Point3D Pove = _pov;
            Moved_X(Pove);
            Moved_Y(Pove);
            Moved_Z(Pove);
            return Pove;
        }
       
        public void Moved_X(Point3D pov)
        {
            //pov.GetSet_X = r * Math.Cos(fi) * Math.Cos(teta);
            
        }

        public void Moved_Y(Point3D pov)
        {
            //pov.GetSet_Y = r * Math.Sin(fi);
        }

        public void Moved_Z(Point3D pov)
        {
            //pov.GetSet_Y = r * Math.Cos(fi) * Math.Cos(teta);
        }


        /*public static void GetScrean(float Height, float Width) {
            ScreenHeight = Height;
            ScreenWidth = Width;   
        }
        public static void up()
        {
            teta += step;
        }
        public static void down()
        {
            teta -= step;
        }
        public static void left() {
            fi += step;
        }
        public static void right()
        {
            fi -= step;
        }
        public static void Foward()
        {
            r += (float)stepR;
        }

        public static void Backward()
        {
            r -= (float)stepR;
        }
        */

        private PointF perspectiveProjection(Point3D p)
        {

            p = p.MinusPoints(povRac());

            p = p.RotateXZ(-fi);
            p = p.RotateYZ(-teta);
            

            if (p.GetSet_Z > 0)
                return new PointF((float)(p.GetSet_X / p.GetSet_Z) * ScreenHeight, (float)(p.GetSet_Y / p.GetSet_Z) * ScreenWidth);
            else
                return new PointF(float.PositiveInfinity, float.PositiveInfinity);
        }
        public Draw(Graphics g, Body a){
            //izracunas poziciju bodya x,y,z
            //a.draw()
        
        }

    }
}
