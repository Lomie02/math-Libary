using System;

public class Vector3
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

		public static Vector3 operator +(Vector3 x, Vector3 y, Vector3 z)
        {
			Vector3 results;

			results.x = x.x + y.x + z.z;
			results.y = x.y + y.y + z.y;
			results.z = x.z + y.z + z.z;

			return results;
        }
	}
}
