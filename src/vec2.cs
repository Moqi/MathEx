﻿using System;

namespace MathEx
{
	[Serializable]
	public struct vec2
	{
		//
		// Fields
		//
		public float x;
		public float y;

		//
		// Static Properties
		//
		public static readonly vec2 zero = new vec2(0, 0);
		public static readonly vec2 empty = new vec2(float.NaN, float.NaN);
		public static readonly vec2 one = new vec2(1, 1);
		public static readonly vec2 right = new vec2(1, 0);
		public static readonly vec2 up = new vec2(0, 1);


		public bool IsEmpty { get { return float.IsNaN(x) || float.IsNaN(y); } }
		public bool IsZero { get { return x == 0 && y == 0; } }

		public float length { get { return MathEx.Sqrt(magnitude); } }
		public float magnitude { get { return x*x + y*y ; } }
		public vec2 normalized { get { return this / length; } }

		public int quad
		{
			get {
				if (x > 0)
					if (y > 0)
						return 0;
					else
						return 1;
				else
					if (y < 0)
						return 2;
					else
						return 3;
			}
		}

		//
		// Operators
		//

		public static vec2 operator *(vec2 a, int d) { return new vec2(a.x * d, a.y * d); }
		public static vec2 operator /(vec2 a, int d) { return new vec2(a.x / d, a.y / d); }
		public static vec2 operator *(vec2 a, float d) { return new vec2(a.x * d, a.y * d); }
		public static vec2 operator /(vec2 a, float d) { return new vec2(a.x / d, a.y / d); }
		public static vec2 operator *(int d, vec2 a) { return new vec2(a.x * d, a.y * d); }
		public static vec2 operator /(int d, vec2 a) { return new vec2(a.x / d, a.y / d); }
		public static vec2 operator *(float d, vec2 a) { return new vec2(a.x * d, a.y * d); }
		public static vec2 operator /(float d, vec2 a) { return new vec2(a.x / d, a.y / d); }
        public static vec2 operator *(vec2 a, vec2 b) { return new vec2(a.x * b.x, a.y * b.y); }
        public static vec2 operator /(vec2 a, vec2 b) { return new vec2(a.x / b.x, a.y / b.y); }



		public static vec2 operator -(vec2 a) { return new vec2(-a.x, -a.y); }
		public static vec2 operator +(vec2 a, vec2 b) { return new vec2(a.x + b.x, a.y + b.y); }
		public static vec2 operator -(vec2 a, vec2 b) { return new vec2(a.x - b.x, a.y - b.y); }


		public vec2(float x, float y)
		{
			this.x = x;
			this.y = y;
		}

		public static vec2 Min(vec2 a, vec2 b)
		{
			return new vec2(Math.Min(a.x, b.x), Math.Min(a.y, b.y));
		}

		public static vec2 Max(vec2 a, vec2 b)
		{
			return new vec2(Math.Max(a.x, b.x), Math.Max(a.y, b.y));
		}

		public override string ToString() { return string.Format("({0},{1})", x, y); }
		public string ToString(string f) { return string.Format("({0},{1})", x.ToString(f), y.ToString(f)); }
	}
}

