using System;

namespace Point2D_3D
{
    public class Point3D : Point2D
    {
        private float z = 0.0f; // Thuộc tính z

        public float Z
        {
            get { return z; }
            set { z = value; }
        }
        // Constructor mặc định
        public Point3D() : base() { }

        // Constructor có tham số
        public Point3D(float _x, float _y, float _z) : base(_x, _y)
        {
            Z = _z;
        }

        // Phương thức SetXYZ để thiết lập giá trị x, y và z
        public void SetXYZ(float x, float y, float z)
        {
            SetXY(x, y); // Gọi phương thức SetXY từ lớp cha
            this.z = z;
        }

        // Phương thức GetXYZ để trả về mảng {x, y, z}
        public float[] GetXYZ()
        {
            return new float[] { X, Y, Z }; // Sử dụng thuộc tính X và Y từ lớp cha
        }

        // Ghi đè phương thức ToString để trả về chuỗi "(x, y, z)"
        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }
}
