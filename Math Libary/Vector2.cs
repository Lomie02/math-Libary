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

        public void Normalise()
        {
            float magnitude = Magnitude();
            if (magnitude != 0)
            {
                x /= magnitude;
                y /= magnitude;
            }
        }
    }



}
