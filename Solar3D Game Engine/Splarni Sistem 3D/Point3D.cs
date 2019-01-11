using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Point3D
    {
        private double x;
        private double y;
        private double z;

        public Point3D()
        {
        }

        public Point3D(double _x, double _y, double _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
        public double GetSet_X {
            get { return x; }
            set { x = value; }
        }
        public double GetSet_Y
        {
            get { return y; }
            set { y = value; }
        }
        public double GetSet_Z
        {
            get { return z; }
            set { z = value; }
        }
        public void Move_Z (double a){
             z = z + a;
        }
        public Point3D AddPoints(Point3D A)
        {
            return new Point3D(x + A.x, y + A.y, z + A.z);
        }
        public Point3D MinusPoints(Point3D A)
        {
            return new Point3D(x - A.x, y - A.y, z - A.z);
        }
        public Point3D RotateXY(double alfa)
        {
            double x1 = x * Math.Cos(alfa) + y * Math.Sin(alfa);
            double y1 = x * (-Math.Sin(alfa)) + y * Math.Cos(alfa);
            return new Point3D(x1, y1, z);
        }
        public Point3D RotateXZ(double alfa)
        {
            double x1 = x * Math.Cos(alfa) + z * (-Math.Sin(alfa));
            double z1 = x * Math.Sin(alfa) + z * Math.Cos(alfa);
            return new Point3D(x1, y, z1);
        }
        public Point3D RotateYZ(double alfa)
        {
            double y1 = y * Math.Cos(alfa) + z * Math.Sin(alfa);
            double z1 = y * (-Math.Sin(alfa)) + z * Math.Cos(alfa);
            return new Point3D(x, y1, z1);
        }

        public Point3D EulerRotate(double ArgOfPer, double Inclination, double LongOfAsNode)
        {
            Point3D rez = RotateXY(LongOfAsNode);
            rez = RotateYZ(Inclination);
            rez = RotateXY(ArgOfPer);
            return rez;
        }
    }
}
