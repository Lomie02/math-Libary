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

		public static Vector3 operator*(Matrix3 lhs, Vector3 rhs)
        {
			Vector3 results;
			results.x = (lhs.m[0] * rhs.x) + (lhs.m[3] * rhs.y) + (lhs.m[6] * rhs.z);
			results.x = (lhs.m[1] * rhs.x) + (lhs.m[4] * rhs.y) + (lhs.m[7] * rhs.z);
			results.x = (lhs.m[2] * rhs.x) + (lhs.m[5] * rhs.y) + (lhs.m[8] * rhs.z);
        }

		public static Matrix3 operator*(Matrix3 lhs,Matrix3 rhs)
        {
			Matrix3 result;

			result.m[0] = lhs + rhs;
			result.m[1] = lhs + rhs;
			result.m[3] = lhs + rhs;
			result.m[4] = lhs + rhs;
			result.m[5] = lhs + rhs;
			result.m[6] = lhs + rhs;
			result.m[7] = lhs + rhs;
			result.m[8] = lhs + rhs;
		


			return result;
        }
	

	}
}