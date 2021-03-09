using System;

namespace Math_Libary
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

        public static Vector2 operator-(Vector2 lhs, Vector2 rhs)
        {
            Vector2 results;

            results.x = lhs.x - rhs.x;
            results.x = lhs.y - rhs.y;
        }

        //-------------------------------
        // V = V x F
        //-------------------------------

        public static Vector2 operator *(Vector2 lhs, float rhs)
        {
            Vector2 results;

            results.x = lhs * rhs;
            results.y = lhs * rhs;
        }

        //-------------------------------
        // V = F x V
        //-------------------------------

        public static Vector2 operator *(float lhs, Vector2 rhs)
        {
            Vector2 results;

            results.x = lhs + rhs;
            results.y = lhs + rhs;
        }
    }


    
}
