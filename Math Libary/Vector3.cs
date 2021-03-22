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

        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        //-----------------------------
        // V = V + V 
        //-----------------------------
        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        {
            Vector3 results;

            results.x = lhs.x + rhs.x;
            results.y = lhs.y + rhs.y;
            results.z = lhs.z + rhs.z;

            return results;
        }

        //-------------------------------
        // V = V - V 
        //-------------------------------

        public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
        {
            Vector3 results;

            results.x = lhs.x - rhs.x;
            results.y = lhs.y - rhs.y;
            results.z = lhs.z - rhs.z;

            return results;
        }

        //-------------------------------
        // V = F * V 
        //-------------------------------

        public static Vector3 operator*(float lhs, Vector3 rhs)
        {
            Vector3 results;

            results.x = lhs * rhs.x;
            results.y = lhs * rhs.y;
            results.z = lhs * rhs.z;

            return results;
        }

        //-------------------------------
        // V = V * F 
        //-------------------------------

        public static Vector3 operator*(Vector3 lhs, float rhs)
        {
            Vector3 results;

            results.x = lhs.x * rhs;
            results.y = lhs.y * rhs;
            results.z = lhs.z * rhs;

            return results;
        }

        //---------------------------------------
        // Magnitude 
        //---------------------------------------

        public float Magnitude()
        {
            return (float)Math.Sqrt((x * x) + (y * y) + (z * z));
        }

        //---------------------------------------
        // Nomralise
        //---------------------------------------

        public void Normalize()
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
            results.y = (z * rhs.x) - (x * rhs.z);
            results.z = (x * rhs.y) - (y * rhs.x);

            return results;

        }

        //---------------------------------------
        // Dot Product
        //---------------------------------------

        public float Dot(Vector3 rhs)
        {
            return (x * rhs.x) + (y * rhs.y) + (z * rhs.z);

        }


    }
}

