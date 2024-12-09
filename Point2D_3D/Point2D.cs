using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point2D_3D
{
    public class Point2D
    {
        private float x = 0.0f;
        private float y = 0.0f;

        public float X
        {
            get { return x; }
            set { x = value; }
        }

        public float Y
        {
            get { return y; }
            set { y = value; }
        }
        public Point2D() { }

        public Point2D(float _x, float _y) 
        {
            X = _x;
            Y = _y;
        }
        public void SetXY(float x, float y) 
        {
            this.x = x;
            this.y = y;
        }
        public float[] GetXY() 
        {
            return new float[] { x, y };
        }
        public virtual string ToString()
        {
            return $"({x}, {y})";
        }
    }
}
