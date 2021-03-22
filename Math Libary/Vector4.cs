using System;

namespace MathClasses
{
    public struct Vector4
    {
        public float x;
        public float y;
        public float z;
        public float w;

        public Vector4(float x, float y, float z, float w )
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        //-----------------------------------------
        // V = V + V 
        //-----------------------------------------
        public static Vector4 operator +(Vector4 x, Vector4 y)
        {
            Vector4 results;

            results.x = x.x + y.x;
            results.y = x.y + y.y;
            results.z = x.z + y.z;
            results.w = x.w + y.w;

            return results;
        }
        //-----------------------------------------
        // V = V - V 
        //-----------------------------------------

        public static Vector4 operator-(Vector4 x, Vector4 y)
        {
            Vector4 results;

            results.x = x.x - y.x;
            results.y = x.y - y.y;
            results.z = x.z - y.z;
            results.w = x.w - y.w;

            return results;
        }

        //---------------------------------------
        // V = F * V 
        //---------------------------------------

        public static Vector4 operator *(float x, Vector4 y )
        {
            Vector4 results;
            results.x = x * y.x;
            results.y = x * y.y;
            results.z = x * y.z;
            results.w = x * y.w;

            return results;
        }

        //--------------------------------------
        //
        //--------------------------------------

        public static Vector4 operator *(Vector4 x, float y)
        {
            Vector4 results;
            results.x = x.x * y;
            results.y = x.y * y;
            results.z = x.z * y;
            results.w = x.w * y;

            return results;
        }

        //--------------------------------------
        
        //--------------------------------------

        public Vector4 Cross(Vector4 rhs)
        {
            Vector4 results;
            results.x = (y * rhs.z) - (z * rhs.y);
            results.y = (z * rhs.x) - (x * rhs.z);
            results.z = (x * rhs.y) - (y * rhs.x);
            results.w = 0;

            return results;
        }

        public float Magnitude()
        {
            return (float)Math.Sqrt((x * x) + (y * y) + (z * z) + (w * w));
        }

        public void Normalize()
        {
            float magnitude = Magnitude();
            if (magnitude != 0)
            {
                x /= magnitude;
                y /= magnitude;
                z /= magnitude;
                w /= magnitude;
            }
        }

        public float Dot(Vector4 rhs)
        {
            return (x * rhs.x) + (y * rhs.y) + (z * rhs.z) + (w * rhs.w);

        }
    }
}
