using System;

namespace MathClasses
{
    public struct Vector4
    {
        public float x;
        public float y;
        public float z;
        public float w;

        public Vector4(float x = 0.0f, float y = 0.0f, float z = 0.0f, float w = 0.0f)
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
            results.x = x * y;
            results.y = x * y;
            results.z = x * y;
            results.w = x * y;
        }

        //--------------------------------------
        //
        //--------------------------------------

        public static Vector4 operator *(Vector4 x, float y)
        {
            Vector4 results;
            results.x = x * y;
            results.y = x * y;
            results.z = x * y;
            results.w = x * y;
        }

        //--------------------------------------
        
        //--------------------------------------

        public Vector4 Cross(Vector4 rhs)
        {
            Vector4 results;
            results.x = (y * rhs.z) - (z * rhs.y);
            results.y = (x * rhs.z) - (z * rhs.x);
            results.z = (x * rhs.y) - (y * rhs.x);
            results.w = 0;
        }

        public void Magnitude()
        {
            return (float)Math.Sqrt((x * x) + (y * y) + (z * z) + (w * w));
        }

        public void Normilize()
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

        public float Dot(Vector3 rhs)
        {
            return (x * rhs.x) + (y * rhs.y) + (z * rhs.z) + (w * rhs.w);

        }
    }
}
