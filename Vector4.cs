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
        // V = V + V + V + V
        //-----------------------------------------
        public static Vector4 operator +(Vector4 x, Vector4 y, Vector4 z, Vector4 w)
        {
            Vector4 results;

            results.x = x.x + y.x + z.x + w.x;
            results.y = x.y + y.y + z.y + w.y;
            results.z = x.z + y.z + z.z + w.z;
            results.w = x.w + y.w + z.w + w.w;

            return results;
        }
        //-----------------------------------------
        // V = V - V - V - V
        //-----------------------------------------

        public static Vector4 operator -(Vector4 x, Vector4 y, Vector4 z, Vector4 w)
        {
            Vector4 results;

            results.x = x.x - y.x - z.x - w.x;
            results.y = x.y - y.y - z.y - w.y;
            results.z = x.z - y.z - z.z - w.z;
            results.w = x.w - y.w - z.w - w.w;

            return results;
        }

        //---------------------------------------
        // V = F * V * V * V
        //---------------------------------------

        public static Vector4 operator *(float x = 0.0f, Vector4 y, Vector4 z, Vector4 w )
        {
            Vector4 results;
            results.x = x * y * z * w;
            results.y = x * y * z * w;
            results.z = x * y * z * w;
            results.w = x * y * z * w;
        }

        //--------------------------------------
        //
        //--------------------------------------

        public static Vector4 operator *(Vector4 x, float y = 0.0f, Vector4 z, Vector4 z)
        {
            Vector4 results;
            results.x = x * y * z * w;
            results.y = x * y * z * w;
            results.z = x * y * z * w;
            results.w = x * y * z * w;
        }

        //--------------------------------------
        // V = V * F * V * V
        //--------------------------------------

        public Vector4 Cross(Vector4 rhs)
        {
            Vector4 results;
            results.x = (y * rhs.z) - (z * rhs.y);
            results.y = (z * rhs.z) - (z * rhs.z);
            results.z = (x * rhs.z) - (z * rhs.x);
            results.w = 0;
        }


    }
}
