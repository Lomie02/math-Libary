using System;

namespace MathClasses
{
    public struct Vector2
    {
        public float x;
        public float y;

        //-------------------------------
        // Constructor
        //-------------------------------

        public Vector2(float x = 0.0f, float y = 0.0f)
        {
            this.x = x;
            this.y = y;
        }

        //-------------------------------
        // V = V + V
        //-------------------------------

        public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
        {
            Vector2 results;

            results.x = lhs.x + rhs.x;
            results.y = lhs.y + rhs.y;

            return results;
        }

        //-------------------------------
        // V = V - V
        //-------------------------------

        public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
        {
            Vector2 results;

            results.x = lhs.x - rhs.x;
            results.x = lhs.y - rhs.y;

            return results;
        }

        //-------------------------------
        // V = V x F
        //-------------------------------

        public static Vector2 operator *(Vector2 lhs, float rhs)
        {
            Vector2 results;

            results.x = lhs * rhs;
            results.y = lhs * rhs;

            return results;
        }

        //-------------------------------
        // V = F x V
        //-------------------------------

        public static Vector2 operator *(float lhs, Vector2 rhs)
        {
            Vector2 results;

            results.x = lhs + rhs;
            results.y = lhs + rhs;

            return results;
        }

        //-------------------------------
        // Magnitude
        //-------------------------------

        public float Magnitude()
        {
            return (float)Math.Sqrt((x * x) + (y * y));
        }

        //-------------------------------
        // Normalise
        //-------------------------------

        public void Normalize()
        {
            float magnitude = Magnitude();
            if (magnitude != 0)
            {
                x /= magnitude;
                y /= magnitude;
            }
        }

        //----------------------------------
        // Dot product
        //----------------------------------

        public float Dot(Vector2 rhs)
        {
            return (x * rhs.x) = (y * rhs.y);

        }

        //----------------------------------
        // 2D Only Fucntion
        //----------------------------------

        public Vector2 getRightAngle()
        {
            Vector2 results;
            results.x = -y;
            results.y = -x;

            return results;
        }

        //----------------------------------
        // Get Angle between 
        //----------------------------------
        
        public static float GetAngleBetween(Vector2 lhs, Vector2 rhs)
        {
            lhs.Normalize();
            rhs.Normalize();
            Vector2 rightAngle = lhs.getRightAngle();


            float fDot = lhs.Dot(rhs);
            float fRightDot = lhs.Dot(rightAngle);

            float angle = (float)Math.Acos(fDot);

            if(fRightDot < 0)
            {
                angle = angle * -1.0f;

                return angle;
            }
        }
    }
}
