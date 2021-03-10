using System;

namespace MathClasses
{
    public struct Vector3
    {
        public float x;
        public float y;
        public float z;

        //-----------------------------
        // Constructor
        //-----------------------------

        public Vector3(float x = 0.0f, float y = 0.0f, float z = 0.0f)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        //-----------------------------
        // V = V + V + V
        //-----------------------------
        public static Vector3 operator +(Vector3 x, Vector3 y, Vector3 z)
        {
            Vector3 results;

            results.x = x.x + y.x + z.z;
            results.y = x.y + y.y + z.y;
            results.z = x.z + y.z + z.z;

            return results;
        }

        //-------------------------------
        // V = V - V - V
        //-------------------------------

        public static Vector3 operator -(Vector3 x, Vector3 y, Vector3 z)
        {
            Vector3 results;

            results.x = x.x - y.x - z.x;
            results.y = x.y - y.y - z.y;
            results.z = x.z - y.z - z.z;
        }

        //-------------------------------
        // V = F * V * V
        //-------------------------------

        public static Vector3 operator *(float x, Vector3 y, Vector3 z)
        {
            Vector3 results;

            results.x = x * y * z;
            results.y = x * y * z;
            results.z = x * y * z;

            return results;
        }

        //-------------------------------
        // V = V * F * V
        //-------------------------------

        public static Vector3 operator *(Vector3 x, float y, Vector3 z)
        {
            Vector3 results;

            results.x = x * y * z;
            results.y = x * y * z;
            results.z = x * y * z;
        }
        //------------------------------
        // V = V * V * F
        //------------------------------
        public static Vector3 operator *(Vector3 x, Vector3 y, float z)
        {
            Vector3 results;

            results.x = x * y * z;
            results.y = x * y * z;
            results.z = x * y * z;
        }

        //---------------------------------------
        // Magnitude 
        //---------------------------------------

        public void Magnitude()
        {
            return (float)Math.Sqrt((x * x) + (y * y) + (z * z));
        }

        //---------------------------------------
        // Nomralise
        //---------------------------------------

        public void Normilize()
        {
            float magnitude = Magnitude();
            if (magnitude != 0)
            {
                x /= magnitude;
                y /= magnitude;
                z /= magnitude;
            }
        }

        //---------------------------------------
        // Cross 
        //---------------------------------------

        public Vector3 Cross(Vector3 rhs)
        {
            Vector3 results;
            results.x = (y * rhs.z) - (z * rhs.y);
            results.y = //
            results.z = //

        }

        //---------------------------------------
        // Dot Product
        //---------------------------------------

        public float Dot(Vector2 rhs)
        {
            return (x * rhs.x) = (y * rhs.y);

        }


    }
}

