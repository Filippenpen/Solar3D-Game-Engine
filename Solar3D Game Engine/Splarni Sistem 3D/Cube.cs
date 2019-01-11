using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Cube : Body
    {
        double H;
        double W;
        double L;

        public Cube(double Height, double Width, double length)
        {
            H = Height;
            W = Width;
            L = length;
            setCube();
            BodyVectorsRotMove = BodyMove(EulerRotate());
        }

        public void setCube()
        {
            
            CubeVectors = new List<Point3D>();
            /*1*/
            CubeVectors.Add(new Point3D(-L/2, -H/2, -W/2));
            /*2*/
            CubeVectors.Add(new Point3D(CubeVectors[0].GetSet_X + L, CubeVectors[0].GetSet_Y, CubeVectors[0].GetSet_Z));
            /*3*/
            CubeVectors.Add(new Point3D(CubeVectors[0].GetSet_X, CubeVectors[0].GetSet_Y + H, CubeVectors[0].GetSet_Z));
            /*4*/
            CubeVectors.Add(new Point3D(CubeVectors[0].GetSet_X + L, CubeVectors[0].GetSet_Y + H, CubeVectors[0].GetSet_Z));
            /*5*/
            CubeVectors.Add(new Point3D(CubeVectors[0].GetSet_X, CubeVectors[0].GetSet_Y, CubeVectors[0].GetSet_Z + W));
            /*6*/
            CubeVectors.Add(new Point3D(CubeVectors[0].GetSet_X + L, CubeVectors[0].GetSet_Y, CubeVectors[0].GetSet_Z + W));
            /*7*/
            CubeVectors.Add(new Point3D(CubeVectors[0].GetSet_X, CubeVectors[0].GetSet_Y + H, CubeVectors[0].GetSet_Z + W));
            /*8*/
            CubeVectors.Add(new Point3D(CubeVectors[0].GetSet_X + L, CubeVectors[0].GetSet_Y + H, CubeVectors[0].GetSet_Z + W));

        }
       
        /*
        public List<Point3D> EulerRotate()
        {
            List<Point3D> CubeVectorsRot = new List<Point3D>();

            foreach (Point3D point in CubeVectors)
            {
                CubeVectorsRot.Add(point.EulerRotate(Arg, Inc, longOf));

            }
            return CubeVectorsRot;
        }*/
        /*
        public List<PointF> CubeVectorsPerPoints()
        {
            List<PointF> CubeVectorsPerPoints = new List<PointF>();

            foreach (Point3D point in EulerRotate())
            {
                CubeVectorsPerPoints.Add(Agent.perspectiveProjection(point));


            }
            int v = 5;
            return CubeVectorsPerPoints;
        }*/
        public override void DrawBody(Graphics a)
        {
        Pen pen = new Pen(Color.White, 1);
            List<PointF> Point = CubeVectorsPerPoints();
            a.DrawLine(pen, Point[0], Point[1]);
            a.DrawLine(pen, Point[0], Point[2]);
            a.DrawLine(pen, Point[3], Point[1]);
            a.DrawLine(pen, Point[3], Point[2]);
            a.DrawLine(pen, Point[4], Point[5]);
            a.DrawLine(pen, Point[4], Point[6]);
            a.DrawLine(pen, Point[7], Point[5]);
            a.DrawLine(pen, Point[7], Point[6]);
            a.DrawLine(pen, Point[0], Point[4]);
            a.DrawLine(pen, Point[1], Point[5]);
            a.DrawLine(pen, Point[2], Point[6]);
            a.DrawLine(pen, Point[3], Point[7]);


        }
    }
}
