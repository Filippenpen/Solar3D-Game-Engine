using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Body
    {
        double Arg;
        double Inc;
        double LongOf;
        Point3D Point = new Point3D(0, 0, 0);
        List<Point3D> BodyVectors;



        public List<Point3D> EulerRotate()
        {
            List<Point3D> CubeVectorsRot = new List<Point3D>();

            foreach (Point3D point in BodyVectors)
            {
                CubeVectorsRot.Add(point.EulerRotate(Arg, Inc, LongOf));

            }
            return CubeVectorsRot;
        }
        public List<Point3D> BodyMove() 
        {
            List<Point3D> CubeVectorsMoved = new List<Point3D>();
            foreach (Point3D point in BodyVectors)
            {
                
            }
        
        
        }
    }
}
