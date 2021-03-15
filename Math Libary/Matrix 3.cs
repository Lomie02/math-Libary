﻿using System;

namespace MathClasses
{
    class Matrix3
    {
        public float[] m;

        public Matrix3(bool bDefault = true)
        {
            m = new float[9];
            m[0] = 1;
            m[1] = 0;
            m[2] = 0;
            m[3] = 0;
            m[4] = 1;
            m[5] = 0;
            m[6] = 0;
            m[7] = 0;
            m[8] = 1;
        }

        //---------------------------------------------

        public Matrix3(float m0, float m1, float m2, float m3, float m4, float m5, float m6, float m7, float m8)
        {
            m = new float[9];
            m[0] = m0;
            m[1] = m1;
            m[2] = m2;
            m[3] = m3;
            m[4] = m4;
            m[5] = m5;
            m[6] = m6;
            m[7] = m7;
            m[8] = m8;
        }

        //---------------------------------------------

        public static Vector3 operator *(Matrix3 lhs, Vector3 rhs)
        {
            Vector3 result;

            result.x = (lhs.m[0] * rhs.x) + (lhs.m[3] * rhs.y) + (lhs.m[6] * rhs.z);
            result.y = (lhs.m[1] * rhs.x) + (lhs.m[4] * rhs.y) + (lhs.m[7] * rhs.z);
            result.z = (lhs.m[2] * rhs.x) + (lhs.m[5] * rhs.y) + (lhs.m[8] * rhs.z);

            return result;
        }

        //---------------------------------------------

        public static Matrix3 operator *(Matrix3 lhs, Matrix3 rhs)
        {
            Matrix3 result = new Matrix3();

            //result.m[0] = 
            //result.m[1] = 
            //result.m[2] = 
            //result.m[3] = 
            //result.m[4] = 
            //result.m[5] = 
            //result.m[6] = 
            //result.m[7] = 
            //result.m[8] = 

            return result;
        }

        //-----------------------------------------------------
        // Set the Rotation of X axis
        //-----------------------------------------------------

        public void SetRotateX(float fRadians)
        {
            m[4] = (float)Math.Cos(fRadians);
            m[5] = (float)Math.Sin(fRadians);
            m[6] = (float)Math.Cos(fRadians);
            m[7] = (float)Math.Sin(fRadians);
            m[8] = (float)Math.Cos(fRadians);
        }

        //-----------------------------------------------------
        // Set the Rotation of Y axis
        //-----------------------------------------------------

        public void SetRotateY(float fRadians)
        {
            m[0] = (float)Math.Cos(fRadians);
            m[2] = (float)Math.Sin(fRadians);
            m[6] = (float)Math.Cos(fRadians);
            m[8] = (float)Math.Sin(fRadians);
        }

        //-----------------------------------------------------
        // Set the Rotation of Z axis
        //-----------------------------------------------------

        public void SetRotateZ(float fRadians)
        {
            m[0] = (float)Math.Cos(fRadians);
            m[1] = (float)Math.Sin(fRadians);
            m[3] = (float)Math.Cos(fRadians);
            m[4] = (float)Math.Sin(fRadians);
        }

        //-----------------------------------------------------
        // Set the Scale 
        //-----------------------------------------------------

        public void SetScale(float x, float y)
        {
            m[0] = (float)Math.Cos(x);
            m[4] = (float)Math.Sin(y);
            
        }

        //-----------------------------------------------------
        // Set the Transform Position
        //-----------------------------------------------------

        public void SetTranslation(float x, float y)
        {

        }

        //-----------------------------------------------------
       
        //-----------------------------------------------------
    }
}
