using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Body
    {
        double Arg;
        double Inc;
        double LongOf;
        Point3D Point = new Point3D(0, 0, 0);
        List<Point3D> BodyVectors;
        List<Point3D> BodyVectorsRotMove;



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
                CubeVectorsMoved.Add(point.AddPoints(Point));
            }
           
            return CubeVectorsMoved;
            
        }
        public virtual void DrawBody(Graphics g) { 
        
        
        }
    }
}
